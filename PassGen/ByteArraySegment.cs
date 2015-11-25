using System;

namespace PassGen {
	internal sealed class ByteArraySegment {
		public byte[] Buffer { get; private set; }
		public int Start { get; private set; }
		public int Length { get; private set; }

		public ByteArraySegment(byte[] buffer) {
			Buffer = buffer;
			Length = Buffer.Length;
			Start = 0;
		}
		public ByteArraySegment(byte[] buffer, int start, int length) {
			Buffer = buffer;
			Start = start;
			Length = length;
		}

		public bool Advance(int length) {
			Start += length;
			Length -= length;
			return (Length <= 0);
		}
	}
}
