using System;

namespace PassGen {
	internal sealed class ByteArraySegment {
		public byte[] Buffer { get; private set; }
		public int Start { get; private set; }
		public int Length { get; private set; }

		public ByteArraySegment(byte[] pBuffer) {
			Buffer = pBuffer;
			Length = Buffer.Length;
			Start = 0;
		}
		public ByteArraySegment(byte[] pBuffer, int pStart, int pLength) {
			Buffer = pBuffer;
			Start = pStart;
			Length = pLength;
		}

		public bool Advance(int pLength) {
			Start += pLength;
			Length -= pLength;
			return (Length <= 0);
		}
	}
}
