﻿// <autogenerated>
//   This file was generated by T4 code generator ObjOf.tt.
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
		public static dynamic ObjOf<TSource>(string key, TSource val) {
			return Currying.ObjOf(key, val);
		}

		public static dynamic ObjOf<TSource>(RamdaPlaceholder key, TSource val) {
			return Currying.ObjOf(key, val);
		}

		public static dynamic ObjOf(string key, RamdaPlaceholder val = null) {
			return Currying.ObjOf(key, val);
		}

		public static dynamic ObjOf(RamdaPlaceholder key = null, RamdaPlaceholder val = null) {
			return Currying.ObjOf(key, val);
		}
	}
}