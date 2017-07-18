﻿// <autogenerated>
//   This file was generated by T4 code generator Subtract.int.tt.
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
		/// Subtracts its second argument from its first argument.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">The first value.</param>
		/// <param name="b">The second value.</param>
		/// <returns>The result of `a - b`.</returns>
		/// <see cref="R.Add"/>
		public static dynamic Subtract(int a, int b) {
			return Currying.Subtract(a, b);
		}

		/// <summary>
		/// Subtracts its second argument from its first argument.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">The first value.</param>
		/// <param name="b">The second value.</param>
		/// <returns>The result of `a - b`.</returns>
		/// <see cref="R.Add"/>
		public static dynamic Subtract(RamdaPlaceholder a, int b) {
			return Currying.Subtract(a, b);
		}

		/// <summary>
		/// Subtracts its second argument from its first argument.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="a">The first value.</param>
		/// <param name="b">The second value.</param>
		/// <returns>The result of `a - b`.</returns>
		/// <see cref="R.Add"/>
		public static dynamic Subtract(int a, RamdaPlaceholder b = null) {
			return Currying.Subtract(a, b);
		}
	}
}