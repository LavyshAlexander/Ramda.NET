﻿// <autogenerated>
//   This file was generated by T4 code generator Values.tt.
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
		public static dynamic Values<TTarget>(TTarget obj) {
			return Currying.Values(obj);
		}
		
		public static dynamic Values<TTarget>(RamdaPlaceholder obj = null) {
			return Currying.Values(obj); 
		}
	}
}