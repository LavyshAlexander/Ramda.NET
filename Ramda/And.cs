﻿// <autogenerated>
//   This file was generated by T4 code generator And.tt.
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
		public static dynamic And(bool a, bool b) {
			return Currying.And(a, b);
		}

		public static dynamic And(RamdaPlaceholder a, bool b) {
			return Currying.And(a, b);
		}

		public static dynamic And(bool a, RamdaPlaceholder b = null) {
			return Currying.And(a, b);
		}

		public static dynamic And(RamdaPlaceholder a = null, RamdaPlaceholder b = null) {
			return Currying.And(a, b);
		}
	}
}