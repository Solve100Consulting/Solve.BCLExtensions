using System;
using System.Runtime.CompilerServices;	
	
namespace Solve.BCLExtensions.UInt32s
{
	public static class UInt32Ext
	{
	    /// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt32"/> or throws an
		/// </summary>
		/// <exception cref="ArgumentNullException" />
		/// <exception cref="FormatException" />
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt32 ToUInt32(this string str) => UInt32.Parse(str);
		
		/// <summary>
        /// Converts a <see cref="String"/> to <see cref="UInt32"/> or returns <paramref name="defaultUInt32"/> if the string is null or poorly formatted
		/// </summary>
		/// <param name="defaultUInt32">The default value returned when <paramref name="str"/> is null or poorly formatted</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt32 ToUInt32OrDefault(this string str, UInt32 defaultUInt32)
		{
			UInt32 val;
			return UInt32.TryParse(str, out val) ? val : defaultUInt32;
		}
	}
}