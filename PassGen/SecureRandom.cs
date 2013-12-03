using System;
using System.Security.Cryptography;

namespace PassGen {
	internal sealed class SecureRandom {
		private RNGCryptoServiceProvider Rand { get; set; }
		private ByteArraySegment LocalRandBuffer { get; set; }

		public SecureRandom() {
			Rand = new RNGCryptoServiceProvider();
		}

		private byte[] GrabBytes(int pBytes) {
			if (LocalRandBuffer == null || LocalRandBuffer.Length < pBytes) {
				byte[] newBuffer = new byte[512];
				Rand.GetBytes(newBuffer);
				LocalRandBuffer = new ByteArraySegment(newBuffer);
			}

			byte[] ret = new byte[pBytes];
			Buffer.BlockCopy(LocalRandBuffer.Buffer, LocalRandBuffer.Start, ret, 0, pBytes);
			LocalRandBuffer.Advance(pBytes);
			return ret;
		}

		public uint NextUInt32() { return BitConverter.ToUInt32(GrabBytes(sizeof(uint)), 0); }
		public int NextInt32() { return BitConverter.ToInt32(GrabBytes(sizeof(int)), 0); }
		public ulong NextUInt64() { return BitConverter.ToUInt64(GrabBytes(sizeof(ulong)), 0); }
		public long NextInt64() { return BitConverter.ToInt64(GrabBytes(sizeof(long)), 0); }
		public double NextDouble() { return BitConverter.ToDouble(GrabBytes(sizeof(double)), 0); }
		public Guid NextGuid() { return new Guid(GrabBytes(16)); }
		public void NextBytes(byte[] pBuffer) { Rand.GetBytes(pBuffer); }
	}
}
