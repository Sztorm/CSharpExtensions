﻿// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
// File is auto-generated. Do not modify as changes may be overwritten.
// If you want to modify this file, edit template file with the same name and .tt extension.
// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

using System;
using System.Runtime.CompilerServices;

namespace Sztorm.Extensions.Enum
{
    public static partial class EnumExtensions
    {
        private static TEnum Int8WithFlagsToggled<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            ref SByte sourceAsInt8 = ref Unsafe.As<TEnum, SByte>(ref source);
            sourceAsInt8 = (SByte)Int64WithFlagsToggled(
                Unsafe.As<TEnum, SByte>(ref source),
                Unsafe.As<TEnum, SByte>(ref flags));
        
            return source;
        }

        private static TEnum Int16WithFlagsToggled<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            ref Int16 sourceAsInt16 = ref Unsafe.As<TEnum, Int16>(ref source);
            sourceAsInt16 = (Int16)Int64WithFlagsToggled(
                Unsafe.As<TEnum, Int16>(ref source),
                Unsafe.As<TEnum, Int16>(ref flags));
        
            return source;
        }

        private static TEnum Int32WithFlagsToggled<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            ref Int32 sourceAsInt32 = ref Unsafe.As<TEnum, Int32>(ref source);
            sourceAsInt32 = (Int32)Int64WithFlagsToggled(
                Unsafe.As<TEnum, Int32>(ref source),
                Unsafe.As<TEnum, Int32>(ref flags));
        
            return source;
        }

        private static TEnum Int64WithFlagsToggled<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            ref Int64 sourceAsInt64 = ref Unsafe.As<TEnum, Int64>(ref source);
            sourceAsInt64 = (Int64)Int64WithFlagsToggled(
                Unsafe.As<TEnum, Int64>(ref source),
                Unsafe.As<TEnum, Int64>(ref flags));
        
            return source;
        }
    }
}
