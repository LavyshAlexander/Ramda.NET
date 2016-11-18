﻿// <autogenerated>
//   This file was generated by T4 code generator MapAccum.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic MapAccum<TArg, TSource, TAccmulator>(Func<TArg, TArg, Tuple> fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(new DelegateDecorator(fn), acc, list);
		}

		public static dynamic MapAccum<TSource, TAccmulator>(RamdaPlaceholder fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(fn, acc, list);
		}

		public static dynamic MapAccum<TArg, TSource>(Func<TArg, TArg, Tuple> fn, RamdaPlaceholder acc, IList<TSource> list) {
			return Currying.MapAccum(new DelegateDecorator(fn), acc, list);
		}

		public static dynamic MapAccum<TArg, TAccmulator>(Func<TArg, TArg, Tuple> fn, TAccmulator acc, RamdaPlaceholder list = null) {
			return Currying.MapAccum(new DelegateDecorator(fn), acc, list);
		}

		public static dynamic MapAccum<TArg>(Func<TArg, TArg, Tuple> fn, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(new DelegateDecorator(fn), acc, list);
		}

		public static dynamic MapAccum<TSource>(dynamic fn, RamdaPlaceholder acc, IList<TSource> list) {
			return Currying.MapAccum(fn, acc, list);
		}

		public static dynamic MapAccum<TAccmulator>(dynamic fn, TAccmulator acc, RamdaPlaceholder list = null) {
			return Currying.MapAccum(fn, acc, list);
		}

		public static dynamic MapAccum(dynamic fn, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(fn, acc, list);
		}

		public static dynamic MapAccum<TSource, TAccmulator>(dynamic fn, TAccmulator acc, IList<TSource> list) {
			return Currying.MapAccum(fn, acc, list);
		}

		public static dynamic MapAccum(RamdaPlaceholder fn = null, RamdaPlaceholder acc = null, RamdaPlaceholder list = null) {
			return Currying.MapAccum(fn, acc, list);
		}
	}
}