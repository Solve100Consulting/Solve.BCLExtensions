using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Decimals
{
	public static class DecimalExt
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Decimal"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Decimal ToDecimal(this string str) => Decimal.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="Decimal"/> or returns <paramref name="defaultDecimal"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultDecimal">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Decimal ToDecimalOrDefault(this string str, Decimal defaultDecimal)
		{
			Decimal val;
			return Decimal.TryParse(str, out val) ? val : defaultDecimal;
		}
	}
}