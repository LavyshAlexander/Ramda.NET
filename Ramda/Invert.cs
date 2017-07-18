﻿// <autogenerated>
//   This file was generated by T4 code generator Invert.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Dynamic;
using System.Collections;
using System.Threading.Tasks;
using static Ramda.NET.Currying;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ramda.NET
{
	public static partial class R
	{	
		/// <summary>
		/// Same as R.invertObj, however this accounts for objects with duplicate valuesby putting the values into an array.
		/// <para />
		/// sig: {s: x} -> {x: [ s, ... ]}
		/// </summary>
		/// <param name="obj">The object or array to invert</param>
		/// <returns>out A new object with keysin an array.</returns>
		public static dynamic Invert<TTarget>(TTarget obj) {
			return Currying.Invert(obj);
		}

		/// <summary>
		/// Same as R.invertObj, however this accounts for objects with duplicate valuesby putting the values into an array.
		/// <para />
		/// sig: {s: x} -> {x: [ s, ... ]}
		/// </summary>
		/// <param name="obj">The object or array to invert</param>
		/// <returns>out A new object with keysin an array.</returns>
		public static dynamic Invert(RamdaPlaceholder obj = null) {
			return Currying.Invert(obj);
		}
	}
}