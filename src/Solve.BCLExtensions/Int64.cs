using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Int64s
{
    public static class Int64Ext
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int64"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ToInt64(this string str) => Int64.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int64"/> or returns <paramref name="defaultInt64"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultInt64">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ToInt64OrDefault(this string str, Int64 defaultInt64)
        {
            Int64 val;
            return Int64.TryParse(str, out val) ? val : defaultInt64;
        }
    }
}