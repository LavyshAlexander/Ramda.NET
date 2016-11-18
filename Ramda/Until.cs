﻿// <autogenerated>
//   This file was generated by T4 code generator Until.tt.
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
		public static dynamic Until<TArg, TReturn>(Func<TArg, bool> pred, Func<TArg, TReturn> fn, TArg init) {
			return Currying.Until(new DelegateDecorator(pred), new DelegateDecorator(fn), init);
		}

		public static dynamic Until<TArg, TReturn>(RamdaPlaceholder pred, Func<TArg, TReturn> fn, TArg init) {
			return Currying.Until(pred, new DelegateDecorator(fn), init);
		}

		public static dynamic Until<TArg>(Func<TArg, bool> pred, RamdaPlaceholder fn, TArg init) {
			return Currying.Until(new DelegateDecorator(pred), fn, init);
		}

		public static dynamic Until<TArg, TReturn>(Func<TArg, bool> pred, Func<TArg, TReturn> fn, RamdaPlaceholder init = null) {
			return Currying.Until(new DelegateDecorator(pred), new DelegateDecorator(fn), init);
		}

		public static dynamic Until<TArg>(Func<TArg, bool> pred, RamdaPlaceholder fn = null, RamdaPlaceholder init = null) {
			return Currying.Until(new DelegateDecorator(pred), fn, init);
		}

		public static dynamic Until<TArg>(RamdaPlaceholder pred, dynamic fn, TArg init) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until<TArg>(dynamic pred, RamdaPlaceholder fn, TArg init) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until(dynamic pred, dynamic fn, RamdaPlaceholder init = null) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until(dynamic pred, RamdaPlaceholder fn = null, RamdaPlaceholder init = null) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until<TArg, TReturn>(dynamic pred, Func<TArg, TReturn> fn, TArg init) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until<TArg>(Func<TArg, bool> pred, dynamic fn, TArg init) {
			return Currying.Until(pred, fn, init);
		}

		public static dynamic Until(RamdaPlaceholder pred = null, RamdaPlaceholder fn = null, RamdaPlaceholder init = null) {
			return Currying.Until(pred, fn, init);
		}
	}
}