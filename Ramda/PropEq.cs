﻿// <autogenerated>
//   This file was generated by T4 code generator PropEq.tt.
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
		public static dynamic PropEq<TValue, TTarget>(string name, TValue val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		public static dynamic PropEq<TValue, TTarget>(RamdaPlaceholder name, TValue val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		public static dynamic PropEq<TTarget>(string name, RamdaPlaceholder val, TTarget str) {
			return Currying.PropEq(name, val, str);
		}

		public static dynamic PropEq<TValue>(string name, TValue val, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}

		public static dynamic PropEq(string name, RamdaPlaceholder val = null, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}

		public static dynamic PropEq(RamdaPlaceholder name = null, RamdaPlaceholder val = null, RamdaPlaceholder str = null) {
			return Currying.PropEq(name, val, str);
		}
	}
}