﻿// <autogenerated>
//   This file was generated by T4 code generator UniqBy.tt.
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
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy<TSource, TReturn>(Func<TSource, TReturn> fn, IList<TSource> list) {
			return Currying.UniqBy(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.UniqBy(fn, list);
		}

		/// <summary>
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy<TSource, TReturn>(Func<TSource, TReturn> fn, RamdaPlaceholder list = null) {
			return Currying.UniqBy(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.UniqBy(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.UniqBy(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list containing only one copy of each element in the originallist, based upon the value returned by applying the supplied function toeach list element. Prefers the first item if the supplied function producesthe same value on two items. `R.equals` is used for comparison.
		/// <para />
		/// sig: (a -> b) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">A function used to produce a value to use during comparisons.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of unique items.</returns>
		public static dynamic UniqBy(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.UniqBy(fn, list);
		}
	}
}