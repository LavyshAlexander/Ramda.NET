﻿// <autogenerated>
//   This file was generated by T4 code generator Partition.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Partition<TTarget, TArg>(Func<TArg, bool> pred, TTarget filterable) {
			return Currying.Partition(pred, filterable);
		}

		public static dynamic Partition<TTarget>(RamdaPlaceholder pred, TTarget filterable) {
			return Currying.Partition(pred, filterable);
		}

		public static dynamic Partition<TArg>(Func<TArg, bool> pred, RamdaPlaceholder filterable = null) {
			return Currying.Partition(pred, filterable);
		}

		public static dynamic Partition(dynamic pred, RamdaPlaceholder filterable = null) {
			return Currying.Partition(pred, filterable);
		}

		public static dynamic Partition<TTarget>(dynamic pred, TTarget filterable) {
			return Currying.Partition(pred, filterable);
		}

		public static dynamic Partition(RamdaPlaceholder pred = null, RamdaPlaceholder filterable = null) {
			return Currying.Partition(pred, filterable);
		}
	}
}