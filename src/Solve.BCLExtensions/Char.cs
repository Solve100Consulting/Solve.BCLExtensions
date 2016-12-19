using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Chars
{
	public static class CharExt
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Char"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Char ToChar(this string str) => Char.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="Char"/> or returns <paramref name="defaultChar"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultChar">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Char ToCharOrDefault(this string str, Char defaultChar)
		{
			Char val;
			return Char.TryParse(str, out val) ? val : defaultChar;
		}
	}
}