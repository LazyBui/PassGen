using System;
using System.Security.Cryptography;

namespace PassGen {
	internal sealed class SecureRandom {
		private RNGCryptoServiceProvider RandomSource { get; set; }
		private ByteArraySegment LocalBuffer { get; set; }

		public SecureRandom() {
			RandomSource = new RNGCryptoServiceProvider();
		}

		private byte[] GrabBytes(int pBytes) {
			if (LocalBuffer == null || LocalBuffer.Length < pBytes) {
				byte[] newBuffer = new byte[16000];
				RandomSource.GetBytes(newBuffer);
				LocalBuffer = new ByteArraySegment(newBuffer);
			}

			byte[] ret = new byte[pBytes];
			Buffer.BlockCopy(LocalBuffer.Buffer, LocalBuffer.Start, ret, 0, pBytes);
			LocalBuffer.Advance(pBytes);
			return ret;
		}

		public uint NextUInt32() { return BitConverter.ToUInt32(GrabBytes(sizeof(uint)), 0); }
		public int NextInt32() { return NextInt32(0, int.MaxValue); }
		public int NextInt32(int pMax) { return NextInt32(0, pMax); }
		public int NextInt32(int pMin, int pMax) {
			if (pMin < 0) throw new ArgumentException("Must be non-negative", nameof(pMin));
			if (pMax < 0) throw new ArgumentException("Must be non-negative", nameof(pMax));
			if (pMax < pMin) throw new ArgumentException("Maximum must be greater than or equal to minimum");
			if (pMax == pMin) return pMin;

			double range = (double)pMax - pMin;
            return (int)Math.Floor(pMin + range * NextDouble());
		}
		public ulong NextUInt64() { return BitConverter.ToUInt64(GrabBytes(sizeof(ulong)), 0); }
		public long NextInt64() { return BitConverter.ToInt64(GrabBytes(sizeof(long)), 0); }
		public double NextDouble() { return NextUInt64() / (ulong.MaxValue + 1.0); }
		public Guid NextGuid() { return new Guid(GrabBytes(16)); }
		public void NextBytes(byte[] pBuffer) { RandomSource.GetBytes(pBuffer); }
	}
}
