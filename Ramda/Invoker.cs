﻿// <autogenerated>
//   This file was generated by T4 code generator Invoker.tt.
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
		public static dynamic Invoker(int arity, string method) {
			return Currying.Invoker(arity, method);
		}

		public static dynamic Invoker(RamdaPlaceholder arity, string method) {
			return Currying.Invoker(arity, method);
		}

		public static dynamic Invoker(int arity, RamdaPlaceholder method = null) {
			return Currying.Invoker(arity, method);
		}

		public static dynamic Invoker(RamdaPlaceholder arity = null, RamdaPlaceholder method = null) {
			return Currying.Invoker(arity, method);
		}
	}
}