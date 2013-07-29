using System;

namespace PassGen.Utilities {
	public static class Randomizer {
		private static Random sState = new Random();

		static Randomizer() { Initialize(); }

		public static int Seed { get; set; }
		public static int Min { get; set; }
		public static int Max { get; set; }

		public static void Initialize() { Initialize(int.MaxValue); }
		public static void Initialize(int pMax) { Initialize(0, pMax); }
		public static void Initialize(int pMin, int pMax) { Initialize(pMin, pMax, GetRaw()); }
		public static void Initialize(int pMin, int pMax, int pSeed) {
			Min = pMin;
			Max = pMax;
			Rehash(pSeed);
		}

		public static void Rehash(int pSeed) { Seed = pSeed; Rehash(); }
		public static void Rehash() { sState = new Random(Seed); }

		private static byte[] GetRawBytes(int pByteCount) {
			byte[] ret = new byte[pByteCount];
			sState.NextBytes(ret);
			return ret;
		}
		public static int GetRaw() { return sState.Next(); }
		public static int Get() { return sState.Next(Min, Max); }
		public static int Get(int pMax) { return sState.Next(pMax); }
		public static int Get(int pMin, int pMax) { return sState.Next(pMin, pMax); }

		public static ulong GetRawUInt64() { return BitConverter.ToUInt64(GetRawBytes(sizeof(ulong)), 0); }
		public static long GetRawInt64() { return BitConverter.ToInt64(GetRawBytes(sizeof(long)), 0); }
		public static uint GetRawUInt32() { return (uint)GetRaw(); }
		public static int GetRawInt32() { return GetRaw(); }
		public static ushort GetRawUInt16() { return (ushort)Get(ushort.MaxValue); }
		public static short GetRawInt16() { return (short)Get(short.MaxValue); }
		public static byte GetRawUInt8() { return (byte)Get(byte.MaxValue); }
		public static sbyte GetRawInt8() { return (sbyte)Get(sbyte.MaxValue); }

		public static double GetDouble() { return sState.NextDouble(); }
		public static ulong GetUInt64(ulong pMax) { return GetRawUInt64() % pMax; }
		public static ulong GetUInt64(ulong pMin, ulong pMax) { return GetUInt64(pMax - pMin) + pMin; }
		public static long GetInt64(long pMax) { return GetRawInt64() % pMax; }
		public static long GetInt64(long pMin, long pMax) { return GetInt64(pMax - pMin) + pMin; }
		public static uint GetUInt32() { return GetUInt32((uint)Min, (uint)Max); }
		public static uint GetUInt32(uint pMax) { return GetRawUInt32() % pMax; }
		public static uint GetUInt32(uint pMin, uint pMax) { return GetUInt32(pMax - pMin) + pMin; }
		public static int GetInt32() { return Get(); }
		public static int GetInt32(int pMax) { return Get(pMax); }
		public static int GetInt32(int pMin, int pMax) { return Get(pMin, pMax); }
		public static ushort GetUInt16() { return GetUInt16((ushort)Min, (ushort)Max); }
		public static ushort GetUInt16(ushort pMax) { return (ushort)(GetRawUInt16() % pMax); }
		public static ushort GetUInt16(ushort pMin, ushort pMax) { return (ushort)(GetUInt16((ushort)(pMax - pMin)) + pMin); }
		public static short GetInt16() { return GetInt16((short)Min, (short)Max); }
		public static short GetInt16(short pMax) { return (short)(GetRawInt16() % pMax); }
		public static short GetInt16(short pMin, short pMax) { return (short)(GetInt16((short)(pMax - pMin)) + pMin); }
		public static byte GetUInt8() { return GetUInt8((byte)Min, (byte)Max); }
		public static byte GetUInt8(byte pMax) { return (byte)(GetRawUInt8() % pMax); }
		public static byte GetUInt8(byte pMin, byte pMax) { return (byte)(GetUInt8((byte)(pMax - pMin)) + pMin); }
		public static sbyte GetInt8() { return GetInt8((sbyte)Min, (sbyte)Max); }
		public static sbyte GetInt8(sbyte pMax) { return (sbyte)(GetRawInt8() % pMax); }
		public static sbyte GetInt8(sbyte pMin, sbyte pMax) { return (sbyte)(GetInt8((sbyte)(pMax - pMin)) + pMin); }
		public static bool GetBool() { return Get(0, 1) == 1; }
	}
}