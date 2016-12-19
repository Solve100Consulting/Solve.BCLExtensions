using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Singles
{
	public static class SingleExt
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Single"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Single ToSingle(this string str) => Single.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="Single"/> or returns <paramref name="defaultSingle"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultSingle">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Single ToSingleOrDefault(this string str, Single defaultSingle)
		{
			Single val;
			return Single.TryParse(str, out val) ? val : defaultSingle;
		}
	}
}