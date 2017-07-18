﻿// <autogenerated>
//   This file was generated by T4 code generator Curry.tt.
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
		/// Returns a curried equivalent of the provided function. The curried functionhas two unusual capabilities. First, its arguments needn't be provided oneat a time. If `f` is a ternary function and `g` is `R.curry(f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.CurryN"/>
		public static dynamic Curry(Delegate fn) {
			return Currying.Curry(Delegate(fn));
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function. The curried functionhas two unusual capabilities. First, its arguments needn't be provided oneat a time. If `f` is a ternary function and `g` is `R.curry(f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.CurryN"/>
		public static dynamic Curry(RamdaPlaceholder fn = null) {
			return Currying.Curry(fn);
		}

		/// <summary>
		/// Returns a curried equivalent of the provided function. The curried functionhas two unusual capabilities. First, its arguments needn't be provided oneat a time. If `f` is a ternary function and `g` is `R.curry(f)`, thefollowing are equivalent:  - `g(1)(2)(3)`  - `g(1)(2, 3)`  - `g(1, 2)(3)`  - `g(1, 2, 3)`Secondly, the special placeholder value `R.__` may be used to specify"gaps", allowing partial application of any combination of arguments,regardless of their positions. If `g` is as above and `_` is `R.__`, thefollowing are equivalent:  - `g(1, 2, 3)`  - `g(_, 2, 3)(1)`  - `g(_, _, 3)(1)(2)`  - `g(_, _, 3)(1, 2)`  - `g(_, 2)(1)(3)`  - `g(_, 2)(1, 3)`  - `g(_, 2)(_, 3)(1)`
		/// <para />
		/// sig: (* -> a) -> (* -> a)
		/// </summary>
		/// <param name="fn">The function to curry.</param>
		/// <returns>A new, curried function.</returns>
		/// <see cref="R.CurryN"/>
		public static dynamic Curry(dynamic fn) {
			return Currying.Curry(Delegate(fn));
		}
	}
}