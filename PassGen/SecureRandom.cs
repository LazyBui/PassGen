using System;
using System.Security.Cryptography;

namespace PassGen {
	internal sealed class SecureRandom {
		private RNGCryptoServiceProvider RandomSource { get; set; }
		private ByteArraySegment LocalBuffer { get; set; }

		public SecureRandom() {
			RandomSource = new RNGCryptoServiceProvider();
		}

		private byte[] GrabBytes(int bytes) {
			if (LocalBuffer == null || LocalBuffer.Length < bytes) {
				byte[] newBuffer = new byte[16000];
				RandomSource.GetBytes(newBuffer);
				LocalBuffer = new ByteArraySegment(newBuffer);
			}

			byte[] result = new byte[bytes];
			Buffer.BlockCopy(LocalBuffer.Buffer, LocalBuffer.Start, result, 0, bytes);
			LocalBuffer.Advance(bytes);
			return result;
		}

		public uint NextUInt32() { return BitConverter.ToUInt32(GrabBytes(sizeof(uint)), 0); }
		public int NextInt32() { return NextInt32(0, int.MaxValue); }
		public int NextInt32(int max) { return NextInt32(0, max); }
		public int NextInt32(int min, int max) {
			if (min < 0) throw new ArgumentException("Must be non-negative", nameof(min));
			if (max < 0) throw new ArgumentException("Must be non-negative", nameof(max));
			if (max < min) throw new ArgumentException($"{nameof(max)} must be greater than or equal to {nameof(min)}");
			if (max == min) return min;

			double range = (double)max - min;
			return (int)Math.Floor(min + range * NextDouble());
		}
		public ulong NextUInt64() { return BitConverter.ToUInt64(GrabBytes(sizeof(ulong)), 0); }
		public long NextInt64() { return BitConverter.ToInt64(GrabBytes(sizeof(long)), 0); }
		public double NextDouble() { return NextUInt64() / (ulong.MaxValue + 1.0); }
		public Guid NextGuid() { return new Guid(GrabBytes(16)); }
		public void NextBytes(byte[] buffer) { RandomSource.GetBytes(buffer); }
	}
}
