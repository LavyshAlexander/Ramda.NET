﻿// <autogenerated>
//   This file was generated by T4 code generator ForEach.object.tt.
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
		/// Iterate over an input `list`, calling a provided function `fn` for eachelement in the list.`fn` receives one argument: *(value)*.Note: `R.forEach` does not skip deleted or unassigned indices (sparsearrays), unlike the native `Array.prototype.forEach` method. For moredetails on this behavior, see:https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach#DescriptionAlso note that, unlike `Array.prototype.forEach`, Ramda's `forEach` returnsthe original array. In some libraries this function is named `each`.Dispatches to the `forEach` method of the second argument, if present.
		/// <para />
		/// sig: (a -> *) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Receives one argument, `value`.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The original list.</returns>
		/// <see cref="R.AddIndex"/>
		public static dynamic ForEach<TSource>(Action<TSource> fn, object list) {
			return Currying.ForEach(Delegate(fn), list);
		}

		/// <summary>
		/// Iterate over an input `list`, calling a provided function `fn` for eachelement in the list.`fn` receives one argument: *(value)*.Note: `R.forEach` does not skip deleted or unassigned indices (sparsearrays), unlike the native `Array.prototype.forEach` method. For moredetails on this behavior, see:https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach#DescriptionAlso note that, unlike `Array.prototype.forEach`, Ramda's `forEach` returnsthe original array. In some libraries this function is named `each`.Dispatches to the `forEach` method of the second argument, if present.
		/// <para />
		/// sig: (a -> *) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Receives one argument, `value`.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The original list.</returns>
		/// <see cref="R.AddIndex"/>
		public static dynamic ForEach(RamdaPlaceholder fn, object list) {
			return Currying.ForEach(fn, list);
		}

		/// <summary>
		/// Iterate over an input `list`, calling a provided function `fn` for eachelement in the list.`fn` receives one argument: *(value)*.Note: `R.forEach` does not skip deleted or unassigned indices (sparsearrays), unlike the native `Array.prototype.forEach` method. For moredetails on this behavior, see:https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/forEach#DescriptionAlso note that, unlike `Array.prototype.forEach`, Ramda's `forEach` returnsthe original array. In some libraries this function is named `each`.Dispatches to the `forEach` method of the second argument, if present.
		/// <para />
		/// sig: (a -> *) -> [a] -> [a]
		/// </summary>
		/// <param name="fn">The function to invoke. Receives one argument, `value`.</param>
		/// <param name="list">The list to iterate over.</param>
		/// <returns>The original list.</returns>
		/// <see cref="R.AddIndex"/>
		public static dynamic ForEach(dynamic fn, object list) {
			return Currying.ForEach(Delegate(fn), list);
		}
	}
}