﻿// <autogenerated>
//   This file was generated by T4 code generator NAry.tt.
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
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(int n, Delegate fn) {
			return Currying.NAry(n, Delegate(fn));
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(RamdaPlaceholder n, Delegate fn) {
			return Currying.NAry(n, Delegate(fn));
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(int n, RamdaPlaceholder fn = null) {
			return Currying.NAry(n, fn);
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(RamdaPlaceholder n, dynamic fn) {
			return Currying.NAry(n, Delegate(fn));
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(int n, dynamic fn) {
			return Currying.NAry(n, Delegate(fn));
		}

		/// <summary>
		/// Wraps a function of any arity (including nullary) in a function that acceptsexactly `n` parameters. Any extraneous parameters will not be passed to thesupplied function.
		/// <para />
		/// sig: Number -> (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="n">The desired arity of the new function.</param>
		/// <param name="fn">The function to wrap.</param>
		/// <returns>A new function wrapping `fn`. The new function is guaranteed to be of arity `n`.</returns>
		public static dynamic NAry(RamdaPlaceholder n = null, RamdaPlaceholder fn = null) {
			return Currying.NAry(n, fn);
		}
	}
}