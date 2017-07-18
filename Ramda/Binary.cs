﻿// <autogenerated>
//   This file was generated by T4 code generator Binary.tt.
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
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly 2 parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: (* -> c) -> (a, b -> c)
		/// </summary>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity 2.</returns>
		public static dynamic Binary(Delegate fn) {
			return Currying.Binary(Delegate(fn));
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly 2 parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: (* -> c) -> (a, b -> c)
		/// </summary>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity 2.</returns>
		public static dynamic Binary(RamdaPlaceholder fn = null) {
			return Currying.Binary(fn);
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly 2 parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: (* -> c) -> (a, b -> c)
		/// </summary>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity 2.</returns>
		public static dynamic Binary(dynamic fn) {
			return Currying.Binary(Delegate(fn));
		}
	}
}