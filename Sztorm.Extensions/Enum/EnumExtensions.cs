using System;
using System.Runtime.CompilerServices;

namespace Sztorm.Extensions.Enum
{
    public static partial class EnumExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long Int64WithFlags(long source, long flags) => source | flags;

        /// <summary>
        ///     Returns <paramref name="source"/> enum with specified <paramref name="flags"/>.
        ///     <br/>
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
        public static TEnum WithFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8WithFlags(flags);
                case 2:
                    return source.Int16WithFlags(flags);
                case 4:
                    return source.Int32WithFlags(flags);
                case 8:
                    return source.Int64WithFlags(flags);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long Int64WithoutFlags(long source, long flags) => source & ~flags;

        /// <summary>
        ///     Returns <paramref name="source"/> enum without specified <paramref name="flags"/>.
        ///     <br/>
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
        public static TEnum WithoutFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8WithoutFlags(flags);
                case 2:
                    return source.Int16WithoutFlags(flags);
                case 4:
                    return source.Int32WithoutFlags(flags);
                case 8:
                    return source.Int64WithoutFlags(flags);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long Int64WithFlagsToggled(long source, long flags) => source ^ flags;

        /// <summary>
        ///     Returns <paramref name="source"/> enum with specified <paramref name="flags"/>
        ///     toggled.<br/>
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
        public static TEnum WithFlagsToggled<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8WithFlagsToggled(flags);
                case 2:
                    return source.Int16WithFlagsToggled(flags);
                case 4:
                    return source.Int32WithFlagsToggled(flags);
                case 8:
                    return source.Int64WithFlagsToggled(flags);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool Int64HasAllFlags(long source, long flags) => (source & flags) == flags;

        /// <summary>
        ///     Returns value indicating whether all the <paramref name="flags"/> are set in the
        ///     current instance. Always returns <see langword="true"/> for flags whose underlying
        ///     value is zero.<br/>
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
        public static bool HasAllFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8HasAllFlags(flags);
                case 2:
                    return source.Int16HasAllFlags(flags);
                case 4:
                    return source.Int32HasAllFlags(flags);
                case 8:
                    return source.Int64HasAllFlags(flags);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool Int64HasAnyFlags(long source, long flags) => (source & flags) != 0L;

        /// <summary>
        ///     Returns value indicating whether any of the <paramref name="flags"/> is set in the
        ///     current instance. Always returns <see langword="false"/> for flags whose underlying
        ///     value is zero.<br/>
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
        public static bool HasAnyFlags<TEnum>(this TEnum source, TEnum flags)
            where TEnum : unmanaged, System.Enum
        {
            int enumSize = Unsafe.SizeOf<TEnum>();

            switch (enumSize)
            {
                case 1:
                    return source.Int8HasAnyFlags(flags);
                case 2:
                    return source.Int16HasAnyFlags(flags);
                case 4:
                    return source.Int32HasAnyFlags(flags);
                case 8:
                    return source.Int64HasAnyFlags(flags);
                default:
                    throw new ArgumentException("Size of underlying enum type is not supported.");
            }
        }
    }
}
