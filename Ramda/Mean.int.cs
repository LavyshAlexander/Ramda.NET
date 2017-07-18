﻿// <autogenerated>
//   This file was generated by T4 code generator Mean.int.tt.
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
		/// Returns the mean of the given list of numbers.
		/// <para />
		/// sig: [Number] -> Number
		/// </summary>
		/// <param name="list">first</param>
		/// <returns>Number</returns>
		public static dynamic Mean(IList<int> list) {
			return Currying.Mean(list);
		}
	}
}