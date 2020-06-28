using System.Collections.Generic;
using NUnit.Framework;
using Sztorm.Extensions.Enum;

namespace Sztorm.Extensions.Tests
{
    public static partial class EnumExtensionsTests
    {
        [TestCaseSource(typeof(EnumExtensionsTests), nameof(AddTestCases))]
        public static TEnum TestAdd<TEnum>(TEnum left, TEnum right)
            where TEnum : unmanaged, System.Enum
            => left.And(right);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(WithFlagsSetToTestCases))]
        public static TEnum TestWithFlagsSetTo<TEnum>(TEnum source, TEnum flags, bool value)
            where TEnum : unmanaged, System.Enum
            => source.WithFlagsSetTo(flags, value);

        private static IEnumerable<TestCaseData> AddTestCases()
        {
            yield return new TestCaseData(BitFlags8.Bit7, BitFlags8.Bit8)
                .Returns(BitFlags8.Bit7 | BitFlags8.Bit8);
            yield return new TestCaseData(BitFlags16.Bit1, BitFlags16.None)
                .Returns(BitFlags16.Bit1);
            yield return new TestCaseData(BitFlags32.Bit11, BitFlags32.Bit10)
                .Returns(BitFlags32.Bit11 | BitFlags32.Bit10);
            yield return new TestCaseData(BitFlags32.Bit1 | BitFlags32.Bit17, BitFlags32.Bit32)
                .Returns(BitFlags32.Bit1 | BitFlags32.Bit17 | BitFlags32.Bit32);
            yield return new TestCaseData(BitFlags32.Bit4, BitFlags32.Bit4)
                .Returns(BitFlags32.Bit4 | BitFlags32.Bit4);
            yield return new TestCaseData(BitFlags64.Bit1, BitFlags64.Bit64)
                .Returns(BitFlags64.Bit1 | BitFlags64.Bit64);
            yield return new TestCaseData(UnsignedBitFlags8.Bit7, UnsignedBitFlags8.Bit8)
                .Returns(UnsignedBitFlags8.Bit7 | UnsignedBitFlags8.Bit8);
            yield return new TestCaseData(UnsignedBitFlags16.Bit1, UnsignedBitFlags16.None)
                .Returns(UnsignedBitFlags16.Bit1);
            yield return new TestCaseData(UnsignedBitFlags32.Bit11, UnsignedBitFlags32.Bit10)
                .Returns(UnsignedBitFlags32.Bit11 | UnsignedBitFlags32.Bit10);
            yield return new TestCaseData(
                UnsignedBitFlags32.Bit1 | UnsignedBitFlags32.Bit17, UnsignedBitFlags32.Bit32)
                .Returns(
                UnsignedBitFlags32.Bit1 | UnsignedBitFlags32.Bit17 | UnsignedBitFlags32.Bit32);
            yield return new TestCaseData(UnsignedBitFlags32.Bit4, UnsignedBitFlags32.Bit4)
                .Returns(UnsignedBitFlags32.Bit4 | UnsignedBitFlags32.Bit4);
            yield return new TestCaseData(UnsignedBitFlags64.Bit1, UnsignedBitFlags64.Bit64)
                .Returns(UnsignedBitFlags64.Bit1 | UnsignedBitFlags64.Bit64);
        }

        private static IEnumerable<TestCaseData> WithFlagsSetToTestCases()
        {
            yield return new TestCaseData(BitFlags8.Bit7, BitFlags8.Bit8 | BitFlags8.Bit1, true)
                .Returns(BitFlags8.Bit7 | BitFlags8.Bit8 | BitFlags8.Bit1);
            yield return new TestCaseData(
                BitFlags8.Bit7 | BitFlags8.Bit5 | BitFlags8.Bit2,
                BitFlags8.Bit5 | BitFlags8.Bit2, false)
                .Returns(BitFlags8.Bit7);
            yield return new TestCaseData(BitFlags16.Bit7, BitFlags16.Bit16 | BitFlags16.Bit1, true)
                .Returns(BitFlags16.Bit7 | BitFlags16.Bit16 | BitFlags16.Bit1);
            yield return new TestCaseData(
                BitFlags16.Bit15 | BitFlags16.Bit5 | BitFlags16.Bit2,
                BitFlags16.Bit5 | BitFlags16.Bit2, false)
                .Returns(BitFlags16.Bit15);
            yield return new TestCaseData(BitFlags32.Bit7, BitFlags32.Bit32 | BitFlags32.Bit1, true)
                .Returns(BitFlags32.Bit7 | BitFlags32.Bit32 | BitFlags32.Bit1);
            yield return new TestCaseData(
                BitFlags32.Bit31 | BitFlags32.Bit5 | BitFlags32.Bit2,
                BitFlags32.Bit5 | BitFlags32.Bit2, false)
                .Returns(BitFlags32.Bit31);
            yield return new TestCaseData(BitFlags64.Bit7, BitFlags64.Bit64 | BitFlags64.Bit1, true)
                .Returns(BitFlags64.Bit7 | BitFlags64.Bit64 | BitFlags64.Bit1);
            yield return new TestCaseData(
                BitFlags64.Bit63 | BitFlags64.Bit5 | BitFlags64.Bit2,
                BitFlags64.Bit5 | BitFlags64.Bit2, false)
                .Returns(BitFlags64.Bit63);
            yield return new TestCaseData(UnsignedBitFlags8.Bit7, UnsignedBitFlags8.Bit8 | UnsignedBitFlags8.Bit1, true)
                .Returns(UnsignedBitFlags8.Bit7 | UnsignedBitFlags8.Bit8 | UnsignedBitFlags8.Bit1);
            yield return new TestCaseData(
                UnsignedBitFlags8.Bit7 | UnsignedBitFlags8.Bit5 | UnsignedBitFlags8.Bit2,
                UnsignedBitFlags8.Bit5 | UnsignedBitFlags8.Bit2, false)
                .Returns(UnsignedBitFlags8.Bit7);
            yield return new TestCaseData(UnsignedBitFlags16.Bit7, UnsignedBitFlags16.Bit16 | UnsignedBitFlags16.Bit1, true)
                .Returns(UnsignedBitFlags16.Bit7 | UnsignedBitFlags16.Bit16 | UnsignedBitFlags16.Bit1);
            yield return new TestCaseData(
                UnsignedBitFlags16.Bit15 | UnsignedBitFlags16.Bit5 | UnsignedBitFlags16.Bit2,
                UnsignedBitFlags16.Bit5 | UnsignedBitFlags16.Bit2, false)
                .Returns(UnsignedBitFlags16.Bit15);
            yield return new TestCaseData(UnsignedBitFlags32.Bit7, UnsignedBitFlags32.Bit32 | UnsignedBitFlags32.Bit1, true)
                .Returns(UnsignedBitFlags32.Bit7 | UnsignedBitFlags32.Bit32 | UnsignedBitFlags32.Bit1);
            yield return new TestCaseData(
                UnsignedBitFlags32.Bit31 | UnsignedBitFlags32.Bit5 | UnsignedBitFlags32.Bit2,
                UnsignedBitFlags32.Bit5 | UnsignedBitFlags32.Bit2, false)
                .Returns(UnsignedBitFlags32.Bit31);
            yield return new TestCaseData(UnsignedBitFlags64.Bit7, UnsignedBitFlags64.Bit64 | UnsignedBitFlags64.Bit1, true)
                .Returns(UnsignedBitFlags64.Bit7 | UnsignedBitFlags64.Bit64 | UnsignedBitFlags64.Bit1);
            yield return new TestCaseData(
                UnsignedBitFlags64.Bit63 | UnsignedBitFlags64.Bit5 | UnsignedBitFlags64.Bit2,
                UnsignedBitFlags64.Bit5 | UnsignedBitFlags64.Bit2, false)
                .Returns(UnsignedBitFlags64.Bit63);
        }
    }
}