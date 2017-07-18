﻿// <autogenerated>
//   This file was generated by T4 code generator Props.tt.
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
		/// Acts as multiple `prop`: array of keys in, array of values out. Preservesorder.
		/// <para />
		/// sig: [k] -> {k: v} -> [v]
		/// </summary>
		/// <param name="ps">The property names to fetch</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The corresponding values or partially applied function.</returns>
		public static dynamic Props<TTarget>(IEnumerable<string> ps, TTarget obj) {
			return Currying.Props(ps, obj);
		}

		/// <summary>
		/// Acts as multiple `prop`: array of keys in, array of values out. Preservesorder.
		/// <para />
		/// sig: [k] -> {k: v} -> [v]
		/// </summary>
		/// <param name="ps">The property names to fetch</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The corresponding values or partially applied function.</returns>
		public static dynamic Props<TTarget>(RamdaPlaceholder ps, TTarget obj) {
			return Currying.Props(ps, obj);
		}

		/// <summary>
		/// Acts as multiple `prop`: array of keys in, array of values out. Preservesorder.
		/// <para />
		/// sig: [k] -> {k: v} -> [v]
		/// </summary>
		/// <param name="ps">The property names to fetch</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The corresponding values or partially applied function.</returns>
		public static dynamic Props(IEnumerable<string> ps, RamdaPlaceholder obj = null) {
			return Currying.Props(ps, obj);
		}

		/// <summary>
		/// Acts as multiple `prop`: array of keys in, array of values out. Preservesorder.
		/// <para />
		/// sig: [k] -> {k: v} -> [v]
		/// </summary>
		/// <param name="ps">The property names to fetch</param>
		/// <param name="obj">The object to query</param>
		/// <returns>The corresponding values or partially applied function.</returns>
		public static dynamic Props(RamdaPlaceholder ps = null, RamdaPlaceholder obj = null) {
			return Currying.Props(ps, obj);
		}
	}
}