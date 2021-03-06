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
        [TestCaseSource(typeof(EnumExtensionsTests), nameof(WithFlagsTestCases))]
        public static TEnum TestWithFlags<TEnum>(TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => source.WithFlags(flags);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(WithoutFlagsTestCases))]
        public static TEnum TestWithoutFlags<TEnum>(TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => source.WithoutFlags(flags);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(WithFlagsSetToTestCases))]
        public static TEnum TestWithFlagsSetTo<TEnum>(TEnum source, TEnum flags, bool value)
            where TEnum : unmanaged, System.Enum
            => source.WithFlagsSetTo(flags, value);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(WithFlagsToggledTestCases))]
        public static TEnum TestWithFlagsToggled<TEnum>(TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => source.WithFlagsToggled(flags);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(HasAllFlagsTestCases))]
        public static bool TestHasAllFlags<TEnum>(TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => source.HasAllFlags(flags);

        [TestCaseSource(typeof(EnumExtensionsTests), nameof(HasAnyFlagsTestCases))]
        public static bool TestHasAnyFlags<TEnum>(TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => source.HasAnyFlags(flags);

        private static IEnumerable<TestCaseData> WithFlagsTestCases()
        {
            yield return new TestCaseData(BF8.Bit7, BF8.Bit8).Returns(BF8.Bit7 | BF8.Bit8);
            yield return new TestCaseData(BF8.Bit3 | BF8.Bit4, BF8.Bit5)
                .Returns(BF8.Bit3 | BF8.Bit4 | BF8.Bit5);
            yield return new TestCaseData(BF8.Bit7, BF8.None).Returns(BF8.Bit7);
            yield return new TestCaseData(BF8.None, BF8.Bit3 | BF8.Bit4)
                .Returns(BF8.Bit3 | BF8.Bit4);

            yield return new TestCaseData(BF16.Bit15, BF16.Bit16).Returns(BF16.Bit15 | BF16.Bit16);
            yield return new TestCaseData(BF16.Bit7 | BF16.Bit8, BF16.Bit9)
                .Returns(BF16.Bit7 | BF16.Bit8 | BF16.Bit9);
            yield return new TestCaseData(BF16.Bit15, BF16.None).Returns(BF16.Bit15);
            yield return new TestCaseData(BF16.None, BF16.Bit7 | BF16.Bit8)
                .Returns(BF16.Bit7 | BF16.Bit8);

            yield return new TestCaseData(BF32.Bit31, BF32.Bit32).Returns(BF32.Bit31 | BF32.Bit32);
            yield return new TestCaseData(BF32.Bit15 | BF32.Bit16, BF32.Bit17)
                .Returns(BF32.Bit15 | BF32.Bit16 | BF32.Bit17);
            yield return new TestCaseData(BF32.Bit31, BF32.None).Returns(BF32.Bit31);
            yield return new TestCaseData(BF32.None, BF32.Bit15 | BF32.Bit16)
                .Returns(BF32.Bit15 | BF32.Bit16);

            yield return new TestCaseData(BF64.Bit63, BF64.Bit64).Returns(BF64.Bit63 | BF64.Bit64);
            yield return new TestCaseData(BF64.Bit31 | BF64.Bit32, BF64.Bit33)
                .Returns(BF64.Bit31 | BF64.Bit32 | BF64.Bit33);
            yield return new TestCaseData(BF64.Bit63, BF64.None).Returns(BF64.Bit63);
            yield return new TestCaseData(BF64.None, BF64.Bit31 | BF64.Bit32)
                .Returns(BF64.Bit31 | BF64.Bit32);

            yield return new TestCaseData(UBF8.Bit7, UBF8.Bit8).Returns(UBF8.Bit7 | UBF8.Bit8);
            yield return new TestCaseData(UBF8.Bit3 | UBF8.Bit4, UBF8.Bit5)
                .Returns(UBF8.Bit3 | UBF8.Bit4 | UBF8.Bit5);
            yield return new TestCaseData(UBF8.Bit7, UBF8.None).Returns(UBF8.Bit7);
            yield return new TestCaseData(UBF8.None, UBF8.Bit3 | UBF8.Bit4)
                .Returns(UBF8.Bit3 | UBF8.Bit4);

            yield return new TestCaseData(UBF16.Bit15, UBF16.Bit16)
                .Returns(UBF16.Bit15 | UBF16.Bit16);
            yield return new TestCaseData(UBF16.Bit7 | UBF16.Bit8, UBF16.Bit9)
                .Returns(UBF16.Bit7 | UBF16.Bit8 | UBF16.Bit9);
            yield return new TestCaseData(UBF16.Bit15, UBF16.None).Returns(UBF16.Bit15);
            yield return new TestCaseData(UBF16.None, UBF16.Bit7 | UBF16.Bit8)
                .Returns(UBF16.Bit7 | UBF16.Bit8);

            yield return new TestCaseData(UBF32.Bit31, UBF32.Bit32)
                .Returns(UBF32.Bit31 | UBF32.Bit32);
            yield return new TestCaseData(UBF32.Bit15 | UBF32.Bit16, UBF32.Bit17)
                .Returns(UBF32.Bit15 | UBF32.Bit16 | UBF32.Bit17);
            yield return new TestCaseData(UBF32.Bit31, UBF32.None).Returns(UBF32.Bit31);
            yield return new TestCaseData(UBF32.None, UBF32.Bit15 | UBF32.Bit16)
                .Returns(UBF32.Bit15 | UBF32.Bit16);

            yield return new TestCaseData(UBF64.Bit63, UBF64.Bit64)
                .Returns(UBF64.Bit63 | UBF64.Bit64);
            yield return new TestCaseData(UBF64.Bit31 | UBF64.Bit32, UBF64.Bit33)
                .Returns(UBF64.Bit31 | UBF64.Bit32 | UBF64.Bit33);
            yield return new TestCaseData(UBF64.Bit63, UBF64.None).Returns(UBF64.Bit63);
            yield return new TestCaseData(UBF64.None, UBF64.Bit31 | UBF64.Bit32)
                .Returns(UBF64.Bit31 | UBF64.Bit32);
        }

        private static IEnumerable<TestCaseData> WithoutFlagsTestCases()
        {
            yield return new TestCaseData(BF8.Bit7 | BF8.Bit8, BF8.Bit8).Returns(BF8.Bit7);
            yield return new TestCaseData(BF8.None, BF8.Bit3).Returns(BF8.None);
            yield return new TestCaseData(BF8.Bit1 | BF8.Bit3, BF8.Bit4)
                .Returns(BF8.Bit1 | BF8.Bit3);

            yield return new TestCaseData(BF16.Bit15 | BF16.Bit16, BF16.Bit16).Returns(BF16.Bit15);
            yield return new TestCaseData(BF16.None, BF16.Bit7).Returns(BF16.None);
            yield return new TestCaseData(BF16.Bit1 | BF16.Bit7, BF16.Bit8)
                .Returns(BF16.Bit1 | BF16.Bit7);

            yield return new TestCaseData(BF32.Bit31 | BF32.Bit32, BF32.Bit32).Returns(BF32.Bit31);
            yield return new TestCaseData(BF32.None, BF32.Bit15).Returns(BF32.None);
            yield return new TestCaseData(BF32.Bit1 | BF32.Bit15, BF32.Bit16)
                .Returns(BF32.Bit1 | BF32.Bit15);

            yield return new TestCaseData(BF64.Bit63 | BF64.Bit64, BF64.Bit64).Returns(BF64.Bit63);
            yield return new TestCaseData(BF64.None, BF64.Bit31).Returns(BF64.None);
            yield return new TestCaseData(BF64.Bit1 | BF64.Bit31, BF64.Bit32)
                .Returns(BF64.Bit1 | BF64.Bit31);

            yield return new TestCaseData(UBF8.Bit7 | UBF8.Bit8, UBF8.Bit8).Returns(UBF8.Bit7);
            yield return new TestCaseData(UBF8.None, UBF8.Bit3).Returns(UBF8.None);
            yield return new TestCaseData(UBF8.Bit1 | UBF8.Bit3, UBF8.Bit4)
                .Returns(UBF8.Bit1 | UBF8.Bit3);

            yield return new TestCaseData(UBF16.Bit15 | UBF16.Bit16, UBF16.Bit16)
                .Returns(UBF16.Bit15);
            yield return new TestCaseData(UBF16.None, UBF16.Bit7).Returns(UBF16.None);
            yield return new TestCaseData(UBF16.Bit1 | UBF16.Bit7, UBF16.Bit8)
                .Returns(UBF16.Bit1 | UBF16.Bit7);

            yield return new TestCaseData(UBF32.Bit31 | UBF32.Bit32, UBF32.Bit32)
                .Returns(UBF32.Bit31);
            yield return new TestCaseData(UBF32.None, UBF32.Bit15).Returns(UBF32.None);
            yield return new TestCaseData(UBF32.Bit1 | UBF32.Bit15, UBF32.Bit16)
                .Returns(UBF32.Bit1 | UBF32.Bit15);

            yield return new TestCaseData(UBF64.Bit63 | UBF64.Bit64, UBF64.Bit64)
                .Returns(UBF64.Bit63);
            yield return new TestCaseData(UBF64.None, UBF64.Bit31).Returns(UBF64.None);
            yield return new TestCaseData(UBF64.Bit1 | UBF64.Bit31, UBF64.Bit32)
                .Returns(UBF64.Bit1 | UBF64.Bit31);
        }

        private static IEnumerable<TestCaseData> WithFlagsSetToTestCases()
        {
            yield return new TestCaseData(BF8.Bit7, BF8.Bit8 | BF8.Bit1, true)
                .Returns(BF8.Bit7 | BF8.Bit8 | BF8.Bit1);
            yield return new TestCaseData(BF8.Bit7 | BF8.Bit5 | BF8.Bit2,
                BF8.Bit5 | BF8.Bit2, false)
                .Returns(BF8.Bit7);
            yield return new TestCaseData(BF8.Bit7, BF8.None, true).Returns(BF8.Bit7);
            yield return new TestCaseData(BF8.Bit7, BF8.None, false).Returns(BF8.Bit7);

            yield return new TestCaseData(BF16.Bit7, BF16.Bit16 | BF16.Bit1, true)
                .Returns(BF16.Bit7 | BF16.Bit16 | BF16.Bit1);
            yield return new TestCaseData(BF16.Bit15 | BF16.Bit5 | BF16.Bit2,
                BF16.Bit5 | BF16.Bit2, false)
                .Returns(BF16.Bit15);
            yield return new TestCaseData(BF16.Bit15, BF16.None, true).Returns(BF16.Bit15);
            yield return new TestCaseData(BF16.Bit15, BF16.None, false).Returns(BF16.Bit15);

            yield return new TestCaseData(BF32.Bit7, BF32.Bit32 | BF32.Bit1, true)
                .Returns(BF32.Bit7 | BF32.Bit32 | BF32.Bit1);
            yield return new TestCaseData(BF32.Bit31 | BF32.Bit5 | BF32.Bit2,
                BF32.Bit5 | BF32.Bit2, false)
                .Returns(BF32.Bit31);
            yield return new TestCaseData(BF32.Bit31, BF32.None, true).Returns(BF32.Bit31);
            yield return new TestCaseData(BF32.Bit31, BF32.None, false).Returns(BF32.Bit31);

            yield return new TestCaseData(BF64.Bit7, BF64.Bit64 | BF64.Bit1, true)
                .Returns(BF64.Bit7 | BF64.Bit64 | BF64.Bit1);
            yield return new TestCaseData(BF64.Bit63 | BF64.Bit5 | BF64.Bit2,
                BF64.Bit5 | BF64.Bit2, false)
                .Returns(BF64.Bit63);
            yield return new TestCaseData(BF64.Bit63, BF64.None, true).Returns(BF64.Bit63);
            yield return new TestCaseData(BF64.Bit63, BF64.None, false).Returns(BF64.Bit63);

            yield return new TestCaseData(UBF8.Bit7, UBF8.Bit8 | UBF8.Bit1, true)
                .Returns(UBF8.Bit7 | UBF8.Bit8 | UBF8.Bit1);
            yield return new TestCaseData(UBF8.Bit7 | UBF8.Bit5 | UBF8.Bit2,
                UBF8.Bit5 | UBF8.Bit2, false)
                .Returns(UBF8.Bit7);
            yield return new TestCaseData(UBF8.Bit7, UBF8.None, true).Returns(UBF8.Bit7);
            yield return new TestCaseData(UBF8.Bit7, UBF8.None, false).Returns(UBF8.Bit7);

            yield return new TestCaseData(UBF16.Bit7, UBF16.Bit16 | UBF16.Bit1, true)
                .Returns(UBF16.Bit7 | UBF16.Bit16 | UBF16.Bit1);
            yield return new TestCaseData(UBF16.Bit15 | UBF16.Bit5 | UBF16.Bit2,
                UBF16.Bit5 | UBF16.Bit2, false)
                .Returns(UBF16.Bit15);
            yield return new TestCaseData(UBF16.Bit15, UBF16.None, true).Returns(UBF16.Bit15);
            yield return new TestCaseData(UBF16.Bit15, UBF16.None, false).Returns(UBF16.Bit15);

            yield return new TestCaseData(UBF32.Bit7, UBF32.Bit32 | UBF32.Bit1, true)
                .Returns(UBF32.Bit7 | UBF32.Bit32 | UBF32.Bit1);
            yield return new TestCaseData(UBF32.Bit31 | UBF32.Bit5 | UBF32.Bit2,
                UBF32.Bit5 | UBF32.Bit2, false)
                .Returns(UBF32.Bit31);
            yield return new TestCaseData(UBF32.Bit31, UBF32.None, true).Returns(UBF32.Bit31);
            yield return new TestCaseData(UBF32.Bit31, UBF32.None, false).Returns(UBF32.Bit31);

            yield return new TestCaseData(UBF64.Bit7, UBF64.Bit64 | UBF64.Bit1, true)
                .Returns(UBF64.Bit7 | UBF64.Bit64 | UBF64.Bit1);
            yield return new TestCaseData(UBF64.Bit63 | UBF64.Bit5 | UBF64.Bit2,
                UBF64.Bit5 | UBF64.Bit2, false)
                .Returns(UBF64.Bit63);
            yield return new TestCaseData(UBF64.Bit63, UBF64.None, true).Returns(UBF64.Bit63);
            yield return new TestCaseData(UBF64.Bit63, UBF64.None, false).Returns(UBF64.Bit63);
        }

        private static IEnumerable<TestCaseData> WithFlagsToggledTestCases()
        {
            yield return new TestCaseData(BF8.Bit3 | BF8.Bit4, BF8.Bit3 | BF8.Bit5)
                .Returns(BF8.Bit4 | BF8.Bit5);
            yield return new TestCaseData(BF8.Bit1 | BF8.Bit8, BF8.None)
                .Returns(BF8.Bit1 | BF8.Bit8);

            yield return new TestCaseData(BF16.Bit7 | BF16.Bit8, BF16.Bit7 | BF16.Bit9)
                .Returns(BF16.Bit8 | BF16.Bit9);
            yield return new TestCaseData(BF16.Bit1 | BF16.Bit16, BF16.None)
                .Returns(BF16.Bit1 | BF16.Bit16);

            yield return new TestCaseData(BF32.Bit15 | BF32.Bit16, BF32.Bit15 | BF32.Bit17)
                .Returns(BF32.Bit16 | BF32.Bit17);
            yield return new TestCaseData(BF32.Bit1 | BF32.Bit32, BF32.None)
                .Returns(BF32.Bit1 | BF32.Bit32);

            yield return new TestCaseData(BF64.Bit31 | BF64.Bit32, BF64.Bit31 | BF64.Bit33)
                .Returns(BF64.Bit32 | BF64.Bit33);
            yield return new TestCaseData(BF64.Bit1 | BF64.Bit64, BF64.None)
                .Returns(BF64.Bit1 | BF64.Bit64);

            yield return new TestCaseData(UBF8.Bit3 | UBF8.Bit4, UBF8.Bit3 | UBF8.Bit5)
                .Returns(UBF8.Bit4 | UBF8.Bit5);
            yield return new TestCaseData(UBF8.Bit1 | UBF8.Bit8, UBF8.None)
                .Returns(UBF8.Bit1 | UBF8.Bit8);

            yield return new TestCaseData(UBF16.Bit7 | UBF16.Bit8, UBF16.Bit7 | UBF16.Bit9)
                .Returns(UBF16.Bit8 | UBF16.Bit9);
            yield return new TestCaseData(UBF16.Bit1 | UBF16.Bit16, UBF16.None)
                .Returns(UBF16.Bit1 | UBF16.Bit16);

            yield return new TestCaseData(UBF32.Bit15 | UBF32.Bit16, UBF32.Bit15 | UBF32.Bit17)
                .Returns(UBF32.Bit16 | UBF32.Bit17);
            yield return new TestCaseData(UBF32.Bit1 | UBF32.Bit32, UBF32.None)
                .Returns(UBF32.Bit1 | UBF32.Bit32);

            yield return new TestCaseData(UBF64.Bit31 | UBF64.Bit32, UBF64.Bit31 | UBF64.Bit33)
                .Returns(UBF64.Bit32 | UBF64.Bit33);
            yield return new TestCaseData(UBF64.Bit1 | UBF64.Bit64, UBF64.None)
                .Returns(UBF64.Bit1 | UBF64.Bit64);
        }

        private static IEnumerable<TestCaseData> HasAllFlagsTestCases()
        {
            yield return new TestCaseData(BF8.Bit3, BF8.Bit3).Returns(true);
            yield return new TestCaseData(BF8.Bit1, BF8.None).Returns(true);
            yield return new TestCaseData(BF8.Bit7 | BF8.Bit8, BF8.Bit7).Returns(true);
            yield return new TestCaseData(BF8.Bit6 | BF8.Bit8, BF8.Bit7).Returns(false);

            yield return new TestCaseData(BF16.Bit7, BF16.Bit7).Returns(true);
            yield return new TestCaseData(BF16.Bit1, BF16.None).Returns(true);
            yield return new TestCaseData(BF16.Bit15 | BF16.Bit16, BF16.Bit15).Returns(true);
            yield return new TestCaseData(BF16.Bit14 | BF16.Bit16, BF16.Bit15).Returns(false);

            yield return new TestCaseData(BF32.Bit15, BF32.Bit15).Returns(true);
            yield return new TestCaseData(BF32.Bit1, BF32.None).Returns(true);
            yield return new TestCaseData(BF32.Bit31 | BF32.Bit32, BF32.Bit31).Returns(true);
            yield return new TestCaseData(BF32.Bit30 | BF32.Bit32, BF32.Bit31).Returns(false);

            yield return new TestCaseData(BF64.Bit31, BF64.Bit31).Returns(true);
            yield return new TestCaseData(BF64.Bit1, BF64.None).Returns(true);
            yield return new TestCaseData(BF64.Bit63 | BF64.Bit64, BF64.Bit63).Returns(true);
            yield return new TestCaseData(BF64.Bit62 | BF64.Bit64, BF64.Bit63).Returns(false);

            yield return new TestCaseData(UBF8.Bit3, UBF8.Bit3).Returns(true);
            yield return new TestCaseData(UBF8.Bit1, UBF8.None).Returns(true);
            yield return new TestCaseData(UBF8.Bit7 | UBF8.Bit8, UBF8.Bit7).Returns(true);
            yield return new TestCaseData(UBF8.Bit6 | UBF8.Bit8, UBF8.Bit7).Returns(false);

            yield return new TestCaseData(UBF16.Bit7, UBF16.Bit7).Returns(true);
            yield return new TestCaseData(UBF16.Bit1, UBF16.None).Returns(true);
            yield return new TestCaseData(UBF16.Bit15 | UBF16.Bit16, UBF16.Bit15).Returns(true);
            yield return new TestCaseData(UBF16.Bit14 | UBF16.Bit16, UBF16.Bit15).Returns(false);

            yield return new TestCaseData(UBF32.Bit15, UBF32.Bit15).Returns(true);
            yield return new TestCaseData(UBF32.Bit1, UBF32.None).Returns(true);
            yield return new TestCaseData(UBF32.Bit31 | UBF32.Bit32, UBF32.Bit31).Returns(true);
            yield return new TestCaseData(UBF32.Bit30 | UBF32.Bit32, UBF32.Bit31).Returns(false);

            yield return new TestCaseData(UBF64.Bit31, UBF64.Bit31).Returns(true);
            yield return new TestCaseData(UBF64.Bit1, UBF64.None).Returns(true);
            yield return new TestCaseData(UBF64.Bit63 | UBF64.Bit64, UBF64.Bit63).Returns(true);
            yield return new TestCaseData(UBF64.Bit62 | UBF64.Bit64, UBF64.Bit63).Returns(false);
        }

        private static IEnumerable<TestCaseData> HasAnyFlagsTestCases()
        {
            yield return new TestCaseData(BF8.Bit3, BF8.Bit3 | BF8.Bit4).Returns(true);
            yield return new TestCaseData(BF8.Bit1, BF8.None).Returns(false);
            yield return new TestCaseData(BF8.Bit7 | BF8.Bit8, BF8.Bit6 | BF8.Bit7).Returns(true);
            yield return new TestCaseData(BF8.Bit6 | BF8.Bit8, BF8.Bit5 | BF8.Bit7).Returns(false);

            yield return new TestCaseData(BF16.Bit7, BF16.Bit7 | BF16.Bit8).Returns(true);
            yield return new TestCaseData(BF16.Bit1, BF16.None).Returns(false);
            yield return new TestCaseData(BF16.Bit15 | BF16.Bit16, BF16.Bit14 | BF16.Bit15)
                .Returns(true);
            yield return new TestCaseData(BF16.Bit14 | BF16.Bit16, BF16.Bit13 | BF16.Bit15)
                .Returns(false);

            yield return new TestCaseData(BF32.Bit15, BF32.Bit15 | BF32.Bit16).Returns(true);
            yield return new TestCaseData(BF32.Bit1, BF32.None).Returns(false);
            yield return new TestCaseData(BF32.Bit31 | BF32.Bit32, BF32.Bit30 | BF32.Bit31)
                .Returns(true);
            yield return new TestCaseData(BF32.Bit30 | BF32.Bit32, BF32.Bit29 | BF32.Bit31)
                .Returns(false);

            yield return new TestCaseData(BF64.Bit31, BF64.Bit31 | BF64.Bit32).Returns(true);
            yield return new TestCaseData(BF64.Bit1, BF64.None).Returns(false);
            yield return new TestCaseData(BF64.Bit63 | BF64.Bit64, BF64.Bit62 | BF64.Bit63)
                .Returns(true);
            yield return new TestCaseData(BF64.Bit62 | BF64.Bit64, BF64.Bit61 | BF64.Bit63)
                .Returns(false);

            yield return new TestCaseData(UBF8.Bit3, UBF8.Bit3 | UBF8.Bit4).Returns(true);
            yield return new TestCaseData(UBF8.Bit1, UBF8.None).Returns(false);
            yield return new TestCaseData(UBF8.Bit7 | UBF8.Bit8, UBF8.Bit6 | UBF8.Bit7)
                .Returns(true);
            yield return new TestCaseData(UBF8.Bit6 | UBF8.Bit8, UBF8.Bit5 | UBF8.Bit7)
                .Returns(false);

            yield return new TestCaseData(UBF16.Bit7, UBF16.Bit7 | UBF16.Bit8).Returns(true);
            yield return new TestCaseData(UBF16.Bit1, UBF16.None).Returns(false);
            yield return new TestCaseData(UBF16.Bit15 | UBF16.Bit16, UBF16.Bit14 | UBF16.Bit15)
                .Returns(true);
            yield return new TestCaseData(UBF16.Bit14 | UBF16.Bit16, UBF16.Bit13 | UBF16.Bit15)
                .Returns(false);

            yield return new TestCaseData(UBF32.Bit15, UBF32.Bit15 | UBF32.Bit16).Returns(true);
            yield return new TestCaseData(UBF32.Bit1, UBF32.None).Returns(false);
            yield return new TestCaseData(UBF32.Bit31 | UBF32.Bit32, UBF32.Bit30 | UBF32.Bit31)
                .Returns(true);
            yield return new TestCaseData(UBF32.Bit30 | UBF32.Bit32, UBF32.Bit29 | UBF32.Bit31)
                .Returns(false);

            yield return new TestCaseData(UBF64.Bit31, UBF64.Bit31 | UBF64.Bit32).Returns(true);
            yield return new TestCaseData(UBF64.Bit1, UBF64.None).Returns(false);
            yield return new TestCaseData(UBF64.Bit63 | UBF64.Bit64, UBF64.Bit62 | UBF64.Bit63)
                .Returns(true);
            yield return new TestCaseData(UBF64.Bit62 | UBF64.Bit64, UBF64.Bit61 | UBF64.Bit63)
                .Returns(false);
        }
    }
}