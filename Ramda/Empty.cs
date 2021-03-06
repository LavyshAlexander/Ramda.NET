﻿// <autogenerated>
//   This file was generated by T4 code generator Empty.tt.
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
		/// Returns the empty value of its argument's type. Ramda defines the emptyvalue of Array (`[]`), Object (`{}`), String (`''`), and Arguments. Othertypes are supported if they define `<![CDATA[<]]>Type<![CDATA[>]]>.empty` and/or`<![CDATA[<]]>Type<![CDATA[>]]>.prototype.empty`.Dispatches to the `empty` method of the first argument, if present.
		/// <para />
		/// sig: a -> a
		/// </summary>
		/// <param name="x">first</param>
		/// <returns>*</returns>
		public static dynamic Empty<TTarget>(TTarget x) {
			return Currying.Empty(x);
		}

		/// <summary>
		/// Returns the empty value of its argument's type. Ramda defines the emptyvalue of Array (`[]`), Object (`{}`), String (`''`), and Arguments. Othertypes are supported if they define `<![CDATA[<]]>Type<![CDATA[>]]>.empty` and/or`<![CDATA[<]]>Type<![CDATA[>]]>.prototype.empty`.Dispatches to the `empty` method of the first argument, if present.
		/// <para />
		/// sig: a -> a
		/// </summary>
		/// <param name="x">first</param>
		/// <returns>*</returns>
		public static dynamic Empty(RamdaPlaceholder x = null) {
			return Currying.Empty(x);
		}
	}
}