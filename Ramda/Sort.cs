﻿// <autogenerated>
//   This file was generated by T4 code generator Sort.tt.
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
		public static dynamic Sort<TArg>(dynamic pred, IList<TArg> list) {
			return Currying.Sort(pred, list);
		}
			
		public static dynamic Sort<TArg>(Func<TArg, TArg, int> pred, IList<TArg> list) {
			return Currying.Sort(pred, list);
		}
		
		public static dynamic Sort<TArg>(RamdaPlaceholder pred, IList<TArg> list) {
			return Currying.Sort(pred, list); 
		}

		public static dynamic Sort(dynamic pred, RamdaPlaceholder list = null) {
			return Currying.Sort(pred, list); 
		}
		
		public static dynamic Sort<TArg>(Func<TArg, TArg, int> pred, RamdaPlaceholder list = null) {
			return Currying.Sort(pred, list); 
		}
		
		public static dynamic Sort<TArg>(RamdaPlaceholder pred = null, RamdaPlaceholder list = null) {
			return Currying.Sort(pred, list);
		}
	}
}