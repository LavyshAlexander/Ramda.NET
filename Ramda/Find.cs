﻿// <autogenerated>
//   This file was generated by T4 code generator Find.tt.
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
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.Find(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.Find(fn, list);
		}

		/// <summary>
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.Find(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.Find(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.Find(Delegate(fn), list);
		}

		/// <summary>
		/// Returns the first element of the list which matches the predicate, or`undefined` if no element matches.Dispatches to the `find` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> a | undefined
		/// </summary>
		/// <param name="fn">The predicate function used to determine if the element is the       desired one.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The element found, or `undefined`.</returns>
		/// <see cref="R.Transduce"/>
		public static dynamic Find(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.Find(fn, list);
		}
	}
}