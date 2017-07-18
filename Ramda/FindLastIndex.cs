﻿// <autogenerated>
//   This file was generated by T4 code generator FindLastIndex.tt.
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
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.FindLastIndex(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.FindLastIndex(fn, list);
		}

		/// <summary>
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.FindLastIndex(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.FindLastIndex(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.FindLastIndex(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the index of the last element of the list which matches thepredicate, or `-1` if no element matches.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> Number
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is thedesired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The index of the element found, or `-1`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic FindLastIndex(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.FindLastIndex(fn, list);
		}
	}
}