using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.UInt16s
{
    public static class UInt16Ext
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt16"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ToUInt16(this string str) => UInt16.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt16"/> or returns <paramref name="defaultUInt16"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultUInt16">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ToUInt16OrDefault(this string str, UInt16 defaultUInt16)
        {
            UInt16 val;
            return UInt16.TryParse(str, out val) ? val : defaultUInt16;
        }
    }
}