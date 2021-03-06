﻿// <autogenerated>
//   This file was generated by T4 code generator Path.tt.
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
		/// Retrieve the value at a given path.
		/// <para />
		/// sig: [Idx] -> {a} -> a | Undefined
		/// </summary>
		/// <param name="path">The path to use.</param>
		/// <param name="obj">The object to retrieve the nested property from.</param>
		/// <returns>The data at `path`.</returns>
		/// <see cref="R.Prop"/>
		public static dynamic Path<TTarget>(IList<object> path, TTarget obj) {
			return Currying.Path(path, obj);
		}

		/// <summary>
		/// Retrieve the value at a given path.
		/// <para />
		/// sig: [Idx] -> {a} -> a | Undefined
		/// </summary>
		/// <param name="path">The path to use.</param>
		/// <param name="obj">The object to retrieve the nested property from.</param>
		/// <returns>The data at `path`.</returns>
		/// <see cref="R.Prop"/>
		public static dynamic Path<TTarget>(RamdaPlaceholder path, TTarget obj) {
			return Currying.Path(path, obj);
		}

		/// <summary>
		/// Retrieve the value at a given path.
		/// <para />
		/// sig: [Idx] -> {a} -> a | Undefined
		/// </summary>
		/// <param name="path">The path to use.</param>
		/// <param name="obj">The object to retrieve the nested property from.</param>
		/// <returns>The data at `path`.</returns>
		/// <see cref="R.Prop"/>
		public static dynamic Path(IList<object> path, RamdaPlaceholder obj = null) {
			return Currying.Path(path, obj);
		}

		/// <summary>
		/// Retrieve the value at a given path.
		/// <para />
		/// sig: [Idx] -> {a} -> a | Undefined
		/// </summary>
		/// <param name="path">The path to use.</param>
		/// <param name="obj">The object to retrieve the nested property from.</param>
		/// <returns>The data at `path`.</returns>
		/// <see cref="R.Prop"/>
		public static dynamic Path(RamdaPlaceholder path = null, RamdaPlaceholder obj = null) {
			return Currying.Path(path, obj);
		}
	}
}