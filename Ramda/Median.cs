﻿// <autogenerated>
//   This file was generated by T4 code generator Median.tt.
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
		public static dynamic Median(IList<double> list) {
			return Currying.Median(list);
		}

		public static dynamic Median(RamdaPlaceholder list = null) {
			return Currying.Median(list);
		}
	}
}