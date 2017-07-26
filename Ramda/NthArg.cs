﻿// <autogenerated>
//   This file was generated by T4 code generator NthArg.tt.
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
		/// Returns a function which returns its nth argument.
		/// <para />
		/// sig: Number -> *... -> *
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>Function</returns>
		public static dynamic NthArg<TSource>(int offset, IList<TSource> list) {
			return Currying.NthArg(offset, list);
		}

		/// <summary>
		/// Returns a function which returns its nth argument.
		/// <para />
		/// sig: Number -> *... -> *
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>Function</returns>
		public static dynamic NthArg<TSource>(RamdaPlaceholder offset, IList<TSource> list) {
			return Currying.NthArg(offset, list);
		}

		/// <summary>
		/// Returns a function which returns its nth argument.
		/// <para />
		/// sig: Number -> *... -> *
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>Function</returns>
		public static dynamic NthArg(int offset, RamdaPlaceholder list = null) {
			return Currying.NthArg(offset, list);
		}

		/// <summary>
		/// Returns a function which returns its nth argument.
		/// <para />
		/// sig: Number -> *... -> *
		/// </summary>
		/// <param name="n">first</param>
		/// <returns>Function</returns>
		public static dynamic NthArg(RamdaPlaceholder offset = null, RamdaPlaceholder list = null) {
			return Currying.NthArg(offset, list);
		}
	}
}