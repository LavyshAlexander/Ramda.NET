﻿// <autogenerated>
//   This file was generated by T4 code generator NAry.tt.
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
		public static dynamic NAry(int n, Delegate fn) {
			return Currying.NAry(n, fn);
		}

		public static dynamic NAry(RamdaPlaceholder n, Delegate fn) {
			return Currying.NAry(n, fn);
		}

		public static dynamic NAry(int n, RamdaPlaceholder fn = null) {
			return Currying.NAry(n, fn);
		}

		public static dynamic NAry(RamdaPlaceholder n = null, RamdaPlaceholder fn = null) {
			return Currying.NAry(n, fn);
		}
	}
}