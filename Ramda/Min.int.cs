﻿// <autogenerated>
//   This file was generated by T4 code generator Min.int.tt.
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
		public static dynamic Min(int a, int b) {
			return Currying.Min(a, b);
		}
		
		public static dynamic Min(RamdaPlaceholder a, int b) {
			return Currying.Min(a, b); 
		}
		
		public static dynamic Min(int a, RamdaPlaceholder b = null) {
			return Currying.Min(a, b); 
		}
	}
}