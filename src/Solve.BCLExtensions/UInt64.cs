using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.UInt64s
{
    public static class UInt64Ext
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt64"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ToUInt64(this string str) => UInt64.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt64"/> or returns <paramref name="defaultUInt64"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultUInt64">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ToUInt64OrDefault(this string str, UInt64 defaultUInt64)
        {
            UInt64 val;
            return UInt64.TryParse(str, out val) ? val : defaultUInt64;
        }
    }
}