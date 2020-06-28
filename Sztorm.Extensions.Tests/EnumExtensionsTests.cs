using System.Collections.Generic;
using NUnit.Framework;
using Sztorm.Extensions.Enum;

namespace Sztorm.Extensions.Tests
{
    using BF8 = EnumExtensionsTests.BitFlags8;
    using BF16 = EnumExtensionsTests.BitFlags16;
    using BF32 = EnumExtensionsTests.BitFlags32;
    using BF64 = EnumExtensionsTests.BitFlags64;
    using UBF8 = EnumExtensionsTests.UnsignedBitFlags8;
    using UBF16 = EnumExtensionsTests.UnsignedBitFlags16;
    using UBF32 = EnumExtensionsTests.UnsignedBitFlags32;
    using UBF64 = EnumExtensionsTests.UnsignedBitFlags64;

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
            yield return new TestCaseData(BF8.Bit7, BF8.Bit8).Returns(BF8.Bit7 | BF8.Bit8);
            yield return new TestCaseData(BF16.Bit1, BF16.None).Returns(BF16.Bit1);
            yield return new TestCaseData(BF32.Bit11, BF32.Bit10).Returns(BF32.Bit11 | BF32.Bit10);
            yield return new TestCaseData(BF32.Bit1 | BF32.Bit17, BF32.Bit32)
                .Returns(BF32.Bit1 | BF32.Bit17 | BF32.Bit32);
            yield return new TestCaseData(BF32.Bit4, BF32.Bit4).Returns(BF32.Bit4 | BF32.Bit4);
            yield return new TestCaseData(BF64.Bit1, BF64.Bit64).Returns(BF64.Bit1 | BF64.Bit64);
            yield return new TestCaseData(UBF8.Bit7, UBF8.Bit8).Returns(UBF8.Bit7 | UBF8.Bit8);
            yield return new TestCaseData(UBF16.Bit1, UBF16.None).Returns(UBF16.Bit1);
            yield return new TestCaseData(UBF32.Bit11, UBF32.Bit10)
                .Returns(UBF32.Bit11 | UBF32.Bit10);
            yield return new TestCaseData(UBF32.Bit1 | UBF32.Bit17, UBF32.Bit32)
                .Returns(UBF32.Bit1 | UBF32.Bit17 | UBF32.Bit32);
            yield return new TestCaseData(UBF32.Bit4, UBF32.Bit4).Returns(UBF32.Bit4 | UBF32.Bit4);
            yield return new TestCaseData(UBF64.Bit1, UBF64.Bit64)
                .Returns(UBF64.Bit1 | UBF64.Bit64);
        }

        private static IEnumerable<TestCaseData> WithFlagsSetToTestCases()
        {
            yield return new TestCaseData(BF8.Bit7, BF8.Bit8 | BF8.Bit1, true)
                .Returns(BF8.Bit7 | BF8.Bit8 | BF8.Bit1);
            yield return new TestCaseData(BF8.Bit7 | BF8.Bit5 | BF8.Bit2,
                BF8.Bit5 | BF8.Bit2, false)
                .Returns(BF8.Bit7);
            yield return new TestCaseData(BF16.Bit7, BF16.Bit16 | BF16.Bit1, true)
                .Returns(BF16.Bit7 | BF16.Bit16 | BF16.Bit1);
            yield return new TestCaseData(BF16.Bit15 | BF16.Bit5 | BF16.Bit2,
                BF16.Bit5 | BF16.Bit2, false)
                .Returns(BF16.Bit15);
            yield return new TestCaseData(BF32.Bit7, BF32.Bit32 | BF32.Bit1, true)
                .Returns(BF32.Bit7 | BF32.Bit32 | BF32.Bit1);
            yield return new TestCaseData(BF32.Bit31 | BF32.Bit5 | BF32.Bit2,
                BF32.Bit5 | BF32.Bit2, false)
                .Returns(BF32.Bit31);
            yield return new TestCaseData(BF64.Bit7, BF64.Bit64 | BF64.Bit1, true)
                .Returns(BF64.Bit7 | BF64.Bit64 | BF64.Bit1);
            yield return new TestCaseData(BF64.Bit63 | BF64.Bit5 | BF64.Bit2,
                BF64.Bit5 | BF64.Bit2, false)
                .Returns(BF64.Bit63);
            yield return new TestCaseData(UBF8.Bit7, UBF8.Bit8 | UBF8.Bit1, true)
                .Returns(UBF8.Bit7 | UBF8.Bit8 | UBF8.Bit1);
            yield return new TestCaseData(UBF8.Bit7 | UBF8.Bit5 | UBF8.Bit2,
                UBF8.Bit5 | UBF8.Bit2, false)
                .Returns(UBF8.Bit7);
            yield return new TestCaseData(UBF16.Bit7, UBF16.Bit16 | UBF16.Bit1, true)
                .Returns(UBF16.Bit7 | UBF16.Bit16 | UBF16.Bit1);
            yield return new TestCaseData(UBF16.Bit15 | UBF16.Bit5 | UBF16.Bit2,
                UBF16.Bit5 | UBF16.Bit2, false)
                .Returns(UBF16.Bit15);
            yield return new TestCaseData(UBF32.Bit7, UBF32.Bit32 | UBF32.Bit1, true)
                .Returns(UBF32.Bit7 | UBF32.Bit32 | UBF32.Bit1);
            yield return new TestCaseData(UBF32.Bit31 | UBF32.Bit5 | UBF32.Bit2,
                UBF32.Bit5 | UBF32.Bit2, false)
                .Returns(UBF32.Bit31);
            yield return new TestCaseData(UBF64.Bit7, UBF64.Bit64 | UBF64.Bit1, true)
                .Returns(UBF64.Bit7 | UBF64.Bit64 | UBF64.Bit1);
            yield return new TestCaseData(UBF64.Bit63 | UBF64.Bit5 | UBF64.Bit2,
                UBF64.Bit5 | UBF64.Bit2, false)
                .Returns(UBF64.Bit63);
        }
    }
}