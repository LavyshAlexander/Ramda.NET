﻿// <autogenerated>
//   This file was generated by T4 code generator Chain.tt.
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
		public static dynamic Chain<TSource, TReturn>(Func<TSource, TReturn> fn, IList<TSource> list) {
			return Currying.Chain(new DelegateDecorator(fn), list);
		}

		public static dynamic Chain<TSource>(RamdaPlaceholder fn, IList<TSource> list) {
			return Currying.Chain(fn, list);
		}

		public static dynamic Chain<TSource, TReturn>(Func<TSource, TReturn> fn, RamdaPlaceholder list = null) {
			return Currying.Chain(new DelegateDecorator(fn), list);
		}

		public static dynamic Chain(dynamic fn, RamdaPlaceholder list = null) {
			return Currying.Chain(fn, list);
		}

		public static dynamic Chain<TSource>(dynamic fn, IList<TSource> list) {
			return Currying.Chain(fn, list);
		}

		public static dynamic Chain(RamdaPlaceholder fn = null, RamdaPlaceholder list = null) {
			return Currying.Chain(fn, list);
		}
	}
}