﻿// <autogenerated>
//   This file was generated by T4 code generator Pluck.string.tt.
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
		/// Returns a new list by plucking the same named property off all objects inthe list supplied.
		/// <para />
		/// sig: k -> [{k: v}] -> [v]
		/// </summary>
		/// <param name="key">The key name to pluck off of each object.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of values for the given key.</returns>
		/// <see cref="R.Props"/>
		public static dynamic Pluck<TSource>(string key, IEnumerable<TSource> list) {
			return Currying.Pluck(key, list);
		}

		/// <summary>
		/// Returns a new list by plucking the same named property off all objects inthe list supplied.
		/// <para />
		/// sig: k -> [{k: v}] -> [v]
		/// </summary>
		/// <param name="key">The key name to pluck off of each object.</param>
		/// <param name="list">The array to consider.</param>
		/// <returns>The list of values for the given key.</returns>
		/// <see cref="R.Props"/>
		public static dynamic Pluck(string key, RamdaPlaceholder list = null) {
			return Currying.Pluck(key, list);
		}
	}
}