using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Bytes
{
    public static class ByteExt
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Byte"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ToByte(this string str) => Byte.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Byte"/> or returns <paramref name="defaultByte"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultByte">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ToByteOrDefault(this string str, Byte defaultByte)
        {
            Byte val;
            return Byte.TryParse(str, out val) ? val : defaultByte;
        }
    }
}