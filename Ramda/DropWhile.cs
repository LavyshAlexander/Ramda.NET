﻿// <autogenerated>
//   This file was generated by T4 code generator DropWhile.tt.
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
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile<TSource>(Func<TSource, bool> fn, IList<TSource> list) {
			return Currying.DropWhile(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.DropWhile(fn, list);
		}

		/// <summary>
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile<TSource>(Func<TSource, bool> fn, RamdaPlaceholder list = null) {
			return Currying.DropWhile(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.DropWhile(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.DropWhile(Delegate(fn), list);
		}

		/// <summary>
		/// Returns a new list excluding the leading elements of a given list whichsatisfy the supplied predicate function. It passes each value to the suppliedpredicate function, skipping elements while the predicate function returns`true`. The predicate function is applied to one argument: *(value)*.Dispatches to the `dropWhile` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: (a -> Boolean) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function called per iteration.</param>
		/// <param name="list">The collection to iterate over.</param>
		/// <returns>A new array.</returns>
		/// <see cref="R.TakeWhile"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic DropWhile(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.DropWhile(fn, list);
		}
	}
}