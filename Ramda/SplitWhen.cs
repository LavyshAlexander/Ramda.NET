﻿// <autogenerated>
//   This file was generated by T4 code generator SplitWhen.tt.
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
		public static dynamic SplitWhen<TValue>(Func<TValue, bool> pred, IList<TValue> list) {
			return Currying.SplitWhen(new DelegateDecorator(pred), list);
		}

		public static dynamic SplitWhen<TValue>(RamdaPlaceholder pred, IList<TValue> list) {
			return Currying.SplitWhen(pred, list);
		}

		public static dynamic SplitWhen<TValue>(Func<TValue, bool> pred, RamdaPlaceholder list = null) {
			return Currying.SplitWhen(new DelegateDecorator(pred), list);
		}

		public static dynamic SplitWhen(dynamic pred, RamdaPlaceholder list = null) {
			return Currying.SplitWhen(pred, list);
		}

		public static dynamic SplitWhen<TValue>(dynamic pred, IList<TValue> list) {
			return Currying.SplitWhen(pred, list);
		}

		public static dynamic SplitWhen(RamdaPlaceholder pred = null, RamdaPlaceholder list = null) {
			return Currying.SplitWhen(pred, list);
		}
	}
}