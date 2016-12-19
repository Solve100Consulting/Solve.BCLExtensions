using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Int16s
{
	public static class Int16Ext
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int16"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int16 ToInt16(this string str) => Int16.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int16"/> or returns <paramref name="defaultInt16"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultInt16">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int16 ToInt16OrDefault(this string str, Int16 defaultInt16)
		{
			Int16 val;
			return Int16.TryParse(str, out val) ? val : defaultInt16;
		}
	}
}