using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Doubles
{
    public static class DoubleExt
    {
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Double"/> or throws an
        /// </summary>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ToDouble(this string str) => Double.Parse(str);
        
        /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Double"/> or returns <paramref name="defaultDouble"/> if the string is null or poorly formatted
        /// </summary>
        /// <param name="defaultDouble">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ToDoubleOrDefault(this string str, Double defaultDouble)
        {
            Double val;
            return Double.TryParse(str, out val) ? val : defaultDouble;
        }
    }
}