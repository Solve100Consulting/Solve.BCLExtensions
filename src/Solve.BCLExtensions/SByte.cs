using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.SBytes
{
    public static class SByteExt
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="SByte"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ToSByte(this string str) => SByte.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="SByte"/> or returns <paramref name="defaultSByte"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultSByte">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ToSByteOrDefault(this string str, SByte defaultSByte)
        {
            SByte val;
            return SByte.TryParse(str, out val) ? val : defaultSByte;
        }
    }
}