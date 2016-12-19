using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.Int32s
{
	public static class Int32Ext
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int32"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int32 ToInt32(this string str) => Int32.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="Int32"/> or returns <paramref name="defaultInt32"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultInt32">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int32 ToInt32OrDefault(this string str, Int32 defaultInt32)
		{
			Int32 val;
			return Int32.TryParse(str, out val) ? val : defaultInt32;
		}
	}
}