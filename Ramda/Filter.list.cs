﻿// <autogenerated>
//   This file was generated by T4 code generator Filter.list.tt.
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
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter<TSource>(Func<TSource, bool> pred, IList<TSource> filterable) {
			return Currying.Filter(Delegate(pred), filterable);
		}

		/// <summary>
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter<TSource>(RamdaPlaceholder pred, IList<TSource> filterable) {
			return Currying.Filter(pred, filterable);
		}

		/// <summary>
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter<TSource>(Func<TSource, bool> pred, RamdaPlaceholder filterable = null) {
			return Currying.Filter(Delegate(pred), filterable);
		}

		/// <summary>
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter(dynamic pred, RamdaPlaceholder filterable = null) {
			return Currying.Filter(Delegate(pred), filterable);
		}

		/// <summary>
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter<TSource>(dynamic pred, IList<TSource> filterable) {
			return Currying.Filter(Delegate(pred), filterable);
		}

		/// <summary>
		/// Takes a predicate and a "filterable", and returns a new filterable of thesame type containing the members of the given filterable which satisfy thegiven predicate.Dispatches to the `filter` method of the second argument, if present.Acts as a transducer if a transformer is given in list position.
		/// <para />
		/// sig: Filterable f => (a -> Boolean) -> f a -> f a
		/// </summary>
		/// <param name="pred">first</param>
		/// <param name="filterable">second</param>
		/// <returns>Array</returns>
		/// <see cref="R.Reject"/>
		/// <see cref="R.Transduce"/>
		/// <see cref="R.AddIndex"/>
		public static dynamic Filter(RamdaPlaceholder pred = null, RamdaPlaceholder filterable = null) {
			return Currying.Filter(pred, filterable);
		}
	}
}