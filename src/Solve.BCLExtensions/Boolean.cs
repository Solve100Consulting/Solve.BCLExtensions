using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Booleans
{
    public static class BooleanExt
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Boolean"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ToBoolean(this string str) => Boolean.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Boolean"/> or returns <paramref name="defaultBoolean"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultBoolean">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ToBooleanOrDefault(this string str, Boolean defaultBoolean)
        {
            Boolean val;
            return Boolean.TryParse(str, out val) ? val : defaultBoolean;
        }
    }
}