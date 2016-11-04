﻿// <autogenerated>
//   This file was generated by T4 code generator Contains.tt.
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
		public static dynamic Contains<TSource>(TSource a, IList<TSource> list) {
			return Currying.Contains(a, list);
		}

		public static dynamic Contains<TSource>(RamdaPlaceholder a, IList<TSource> list) {
			return Currying.Contains(a, list);
		}

		public static dynamic Contains<TSource>(TSource a, RamdaPlaceholder list = null) {
			return Currying.Contains(a, list);
		}

		public static dynamic Contains(RamdaPlaceholder a = null, RamdaPlaceholder list = null) {
			return Currying.Contains(a, list);
		}
	}
}