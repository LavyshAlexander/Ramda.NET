﻿// <autogenerated>
//   This file was generated by T4 code generator PropEq.tt.
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
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq<TValue, TTarget>(string name, TValue val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		/// <summary>
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq<TValue, TTarget>(RamdaPlaceholder name, TValue val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		/// <summary>
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq<TTarget>(string name, RamdaPlaceholder val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		/// <summary>
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq<TValue>(string name, TValue val, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}

		/// <summary>
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq(string name, RamdaPlaceholder val = null, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}

		/// <summary>
		/// Returns `true` if the specified object property is equal, in `R.equals`terms, to the given value; `false` otherwise.
		/// <para />
		/// sig: String -> a -> Object -> Boolean
		/// </summary>
		/// <param name="name">first</param>
		/// <param name="val">second</param>
		/// <param name="obj">third</param>
		/// <returns>Boolean</returns>
		/// <see cref="R.Equals"/>
		/// <see cref="R.PropSatisfies"/>
		public static dynamic PropEq(RamdaPlaceholder name = null, RamdaPlaceholder val = null, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}
	}
}