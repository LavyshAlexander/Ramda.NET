﻿// <autogenerated>
//   This file was generated by T4 code generator Chain.object.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Dynamic;
using System.Collections;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		public static dynamic Chain<TTarget>(Delegate fn, TTarget list) {
			return Currying.Chain(Delegate(fn), list);
		}

		public static dynamic Chain<TTarget>(RamdaPlaceholder fn, TTarget list) {
			return Currying.Chain(fn, list);
		}

		public static dynamic Chain<TTarget>(dynamic fn, TTarget list) {
			return Currying.Chain(Delegate(fn), list);
		}
	}
}