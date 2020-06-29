// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
// File is auto-generated. Do not modify as changes may be overwritten.
// If you want to modify this file, edit template file with the same name and .tt extension.
// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

using System;
using System.Runtime.CompilerServices;

namespace Sztorm.Extensions.Enum
{
    public static partial class EnumExtensions
    {
        private static bool Int8HasAnyFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => Int64HasAnyFlags(
                Unsafe.As<TEnum, SByte>(ref source), Unsafe.As<TEnum, SByte>(ref flags));

        private static bool Int16HasAnyFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => Int64HasAnyFlags(
                Unsafe.As<TEnum, Int16>(ref source), Unsafe.As<TEnum, Int16>(ref flags));

        private static bool Int32HasAnyFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => Int64HasAnyFlags(
                Unsafe.As<TEnum, Int32>(ref source), Unsafe.As<TEnum, Int32>(ref flags));

        private static bool Int64HasAnyFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
            => Int64HasAnyFlags(
                Unsafe.As<TEnum, Int64>(ref source), Unsafe.As<TEnum, Int64>(ref flags));
    }
}
