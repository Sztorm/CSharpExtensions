using System;
using System.Runtime.CompilerServices;

namespace Sztorm.Extensions.Enum
{
    public static partial class EnumExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long Int64And(long source, long flags) => source | flags;

        /// <summary>
        ///     Returns aggregation of two flags.<br/>
        ///     Supported enum sizes are 1, 2, 4 and 8-byte.
        ///     <para>
        ///         Exceptions:<br/>
        ///         <see cref="ArgumentException"/> Size of underlying enum type is not supported.
        ///     </para>
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="source"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TEnum And<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8And(flags);
                case 2:
                    return source.Int16And(flags);
                case 4:
                    return source.Int32And(flags);
                case 8:
                    return source.Int64And(flags);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long Int64WithFlagSetTo(long source, long flags, bool value)
        {
            ref byte valueByte = ref Unsafe.As<bool, byte>(ref value);
            source ^= (-valueByte ^ source) & flags;

            return source;
        }

        /// <summary>
        ///     Returns <paramref name="source"/> enum with specified <paramref name="flags"/> set
        ///     to <paramref name="value"/>.<br/>
        ///     Supported enum sizes are 1, 2, 4 and 8-byte.
        ///     <para>
        ///         Exceptions:<br/>
        ///         <see cref="ArgumentException"/> Size of underlying enum type is not supported.
        ///     </para>
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="source"></param>
        /// <param name="flags"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TEnum WithFlagsSetTo<TEnum>(this TEnum source, TEnum flags, bool value)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8WithFlagsSetTo(flags, value);
                case 2:
                    return source.Int16WithFlagsSetTo(flags, value);
                case 4:
                    return source.Int32WithFlagsSetTo(flags, value);
                case 8:
                    return source.Int64WithFlagsSetTo(flags, value);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }
    }
}
