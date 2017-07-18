﻿// <autogenerated>
//   This file was generated by T4 code generator Clone.tt.
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
		/// Creates a deep copy of the value which may contain (nested) `Array`s and`Object`s, `Number`s, `String`s, `Boolean`s and `Date`s. `Function`s areassigned by reference rather than copiedDispatches to a `clone` method if present.
		/// <para />
		/// sig: {*} -> {*}
		/// </summary>
		/// <param name="value">The object or array to clone</param>
		/// <returns>A deeply cloned copy of `val`</returns>
		public static dynamic Clone<TTarget>(TTarget value) {
			return Currying.Clone(value);
		}

		/// <summary>
		/// Creates a deep copy of the value which may contain (nested) `Array`s and`Object`s, `Number`s, `String`s, `Boolean`s and `Date`s. `Function`s areassigned by reference rather than copiedDispatches to a `clone` method if present.
		/// <para />
		/// sig: {*} -> {*}
		/// </summary>
		/// <param name="value">The object or array to clone</param>
		/// <returns>A deeply cloned copy of `val`</returns>
		public static dynamic Clone(RamdaPlaceholder value = null) {
			return Currying.Clone(value);
		}
	}
}