﻿// <autogenerated>
//   This file was generated by T4 code generator XProd.tt.
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
		public static dynamic XProd<TSource1, TSource2>(IList<TSource1> @as, IList<TSource2> bs) {
			return Currying.XProd(@as, bs);
		}

		public static dynamic XProd<TSource2>(RamdaPlaceholder @as, IList<TSource2> bs) {
			return Currying.XProd(@as, bs);
		}

		public static dynamic XProd<TSource1>(IList<TSource1> @as, RamdaPlaceholder bs = null) {
			return Currying.XProd(@as, bs);
		}

		public static dynamic XProd(RamdaPlaceholder @as = null, RamdaPlaceholder bs = null) {
			return Currying.XProd(@as, bs);
		}
	}
}