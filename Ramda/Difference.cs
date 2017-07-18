﻿// <autogenerated>
//   This file was generated by T4 code generator Difference.tt.
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
		/// Finds the set (i.e. no duplicates) of all elements in the first list notcontained in the second list. Objects and Arrays are compared are comparedin terms of value equality, not reference equality.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` that are not in `list2`.</returns>
		/// <see cref="R.DifferenceWith"/>
		/// <see cref="R.SymmetricDifference"/>
		/// <see cref="R.SymmetricDifferenceWith"/>
		public static dynamic Difference<TSource>(IList<TSource> list1, IList<TSource> list2) {
			return Currying.Difference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements in the first list notcontained in the second list. Objects and Arrays are compared are comparedin terms of value equality, not reference equality.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` that are not in `list2`.</returns>
		/// <see cref="R.DifferenceWith"/>
		/// <see cref="R.SymmetricDifference"/>
		/// <see cref="R.SymmetricDifferenceWith"/>
		public static dynamic Difference<TSource>(RamdaPlaceholder list1, IList<TSource> list2) {
			return Currying.Difference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements in the first list notcontained in the second list. Objects and Arrays are compared are comparedin terms of value equality, not reference equality.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` that are not in `list2`.</returns>
		/// <see cref="R.DifferenceWith"/>
		/// <see cref="R.SymmetricDifference"/>
		/// <see cref="R.SymmetricDifferenceWith"/>
		public static dynamic Difference<TSource>(IList<TSource> list1, RamdaPlaceholder list2 = null) {
			return Currying.Difference(list1, list2);
		}

		/// <summary>
		/// Finds the set (i.e. no duplicates) of all elements in the first list notcontained in the second list. Objects and Arrays are compared are comparedin terms of value equality, not reference equality.
		/// <para />
		/// sig: [*] -> [*] -> [*]
		/// </summary>
		/// <param name="list1">The first list.</param>
		/// <param name="list2">The second list.</param>
		/// <returns>The elements in `list1` that are not in `list2`.</returns>
		/// <see cref="R.DifferenceWith"/>
		/// <see cref="R.SymmetricDifference"/>
		/// <see cref="R.SymmetricDifferenceWith"/>
		public static dynamic Difference(RamdaPlaceholder list1 = null, RamdaPlaceholder list2 = null) {
			return Currying.Difference(list1, list2);
		}
	}
}