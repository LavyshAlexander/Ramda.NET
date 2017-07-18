﻿// <autogenerated>
//   This file was generated by T4 code generator Max.int.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// Returns the larger of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MaxBy"/>
		/// <see cref="R.Min"/>
		public static dynamic Max(int a, int b) {
			return Currying.Max(a, b);
		}

		/// <summary>
		/// Returns the larger of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MaxBy"/>
		/// <see cref="R.Min"/>
		public static dynamic Max(RamdaPlaceholder a, int b) {
			return Currying.Max(a, b);
		}

		/// <summary>
		/// Returns the larger of its two arguments.
		/// <para />
		/// sig: Ord a => a -> a -> a
		/// </summary>
		/// <param name="a">first</param>
		/// <param name="b">second</param>
		/// <returns>*</returns>
		/// <see cref="R.MaxBy"/>
		/// <see cref="R.Min"/>
		public static dynamic Max(int a, RamdaPlaceholder b = null) {
			return Currying.Max(a, b);
		}
	}
}