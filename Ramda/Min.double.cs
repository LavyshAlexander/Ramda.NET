﻿// <autogenerated>
//   This file was generated by T4 code generator Min.double.tt.
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
		public static dynamic Min(double a, double b) {
			return Currying.Min(a, b);
		}

		public static dynamic Min(RamdaPlaceholder a, double b) {
			return Currying.Min(a, b);
		}

		public static dynamic Min(double a, RamdaPlaceholder b = null) {
			return Currying.Min(a, b);
		}
	}
}