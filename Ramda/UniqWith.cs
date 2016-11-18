﻿// <autogenerated>
//   This file was generated by T4 code generator UniqWith.tt.
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
		public static dynamic UniqWith<TSource>(Func<TSource, TSource, bool> pred, IList<TSource> list) {
			return Currying.UniqWith(new DelegateDecorator(pred), list);
		}

		public static dynamic UniqWith<TSource>(RamdaPlaceholder pred, IList<TSource> list) {
			return Currying.UniqWith(pred, list);
		}

		public static dynamic UniqWith<TSource>(Func<TSource, TSource, bool> pred, RamdaPlaceholder list = null) {
			return Currying.UniqWith(new DelegateDecorator(pred), list);
		}

		public static dynamic UniqWith(dynamic pred, RamdaPlaceholder list = null) {
			return Currying.UniqWith(pred, list);
		}

		public static dynamic UniqWith<TSource>(dynamic pred, IList<TSource> list) {
			return Currying.UniqWith(pred, list);
		}

		public static dynamic UniqWith(RamdaPlaceholder pred = null, RamdaPlaceholder list = null) {
			return Currying.UniqWith(pred, list);
		}
	}
}