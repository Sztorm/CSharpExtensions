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

        private static IEnumerable<TestCaseData> AddTestCases()
        {
            yield return new TestCaseData(BitFlags8.Bit7, BitFlags8.Bit8)
                .Returns((BitFlags8)(64 | -128));
            yield return new TestCaseData(BitFlags16.Bit1, BitFlags16.None)
                .Returns((BitFlags16)1);
            yield return new TestCaseData(BitFlags32.Bit11, BitFlags32.Bit10)
                .Returns((BitFlags32)(1024 | 512));
            yield return new TestCaseData(BitFlags32.Bit1 | BitFlags32.Bit17, BitFlags32.Bit32)
                .Returns((BitFlags32)(1 | 65536 | -2147483648));
            yield return new TestCaseData(BitFlags32.Bit4, BitFlags32.Bit4)
                .Returns((BitFlags32)(8 | 8));
            yield return new TestCaseData(BitFlags64.Bit1, BitFlags64.Bit64)
                .Returns((BitFlags64)(-9223372036854775808L | 1L));
            yield return new TestCaseData(UnsignedBitFlags8.Bit7, UnsignedBitFlags8.Bit8)
                .Returns((UnsignedBitFlags8)(64 | 128));
            yield return new TestCaseData(UnsignedBitFlags16.Bit1, UnsignedBitFlags16.None)
                .Returns((UnsignedBitFlags16)1);
            yield return new TestCaseData(UnsignedBitFlags32.Bit11, UnsignedBitFlags32.Bit10)
                .Returns((UnsignedBitFlags32)(1024U | 512U));
            yield return new TestCaseData(
                UnsignedBitFlags32.Bit1 | UnsignedBitFlags32.Bit17, UnsignedBitFlags32.Bit32)
                .Returns((UnsignedBitFlags32)(1U | 65536U | 2147483648U));
            yield return new TestCaseData(UnsignedBitFlags32.Bit4, UnsignedBitFlags32.Bit4)
                .Returns((UnsignedBitFlags32)(8U | 8U));
            yield return new TestCaseData(UnsignedBitFlags64.Bit1, UnsignedBitFlags64.Bit64)
                .Returns((UnsignedBitFlags64)(9223372036854775808UL | 1UL));
        }
    }
}