﻿// <autogenerated>
//   This file was generated by T4 code generator Slice.tt.
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
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice<TSource>(int fromIndex, int toIndex, IList<TSource> list) {
			return Currying.Slice(fromIndex, toIndex, list);
		}

		/// <summary>
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice<TSource>(RamdaPlaceholder fromIndex, int toIndex, IList<TSource> list) {
			return Currying.Slice(fromIndex, toIndex, list);
		}

		/// <summary>
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice<TSource>(int fromIndex, RamdaPlaceholder toIndex, IList<TSource> list) {
			return Currying.Slice(fromIndex, toIndex, list);
		}

		/// <summary>
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice(int fromIndex, int toIndex, RamdaPlaceholder list = null) {
			return Currying.Slice(fromIndex, toIndex, list);
		}

		/// <summary>
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice(int fromIndex, RamdaPlaceholder toIndex = null, RamdaPlaceholder list = null) {
			return Currying.Slice(fromIndex, toIndex, list);
		}

		/// <summary>
		/// Returns the elements of the given list or string (or object with a `slice`method) from `fromIndex` (inclusive) to `toIndex` (exclusive).Dispatches to the `slice` method of the third argument, if present.
		/// <para />
		/// sig: Number -> Number -> [a] -> [a]
		/// </summary>
		/// <param name="fromIndex">The start index (inclusive).</param>
		/// <param name="toIndex">The end index (exclusive).</param>
		/// <param name="list">third</param>
		/// <returns>*</returns>
		public static dynamic Slice(RamdaPlaceholder fromIndex = null, RamdaPlaceholder toIndex = null, RamdaPlaceholder list = null) {
			return Currying.Slice(fromIndex, toIndex, list);
		}
	}
}