﻿// <autogenerated>
//   This file was generated by T4 code generator Bind.tt.
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
		public static dynamic Bind<TTarget>(Delegate fn, TTarget thisObject) {
			return Currying.Bind(fn, thisObject);
		}

		public static dynamic Bind<TTarget>(RamdaPlaceholder fn, TTarget thisObject) {
			return Currying.Bind(fn, thisObject);
		}

		public static dynamic Bind(Delegate fn, RamdaPlaceholder thisObject = null) {
			return Currying.Bind(fn, thisObject);
		}

		public static dynamic Bind(RamdaPlaceholder fn = null, RamdaPlaceholder thisObject = null) {
			return Currying.Bind(fn, thisObject);
		}
	}
}