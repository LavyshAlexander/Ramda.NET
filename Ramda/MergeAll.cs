﻿// <autogenerated>
//   This file was generated by T4 code generator MergeAll.tt.
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
		public static dynamic MergeAll<TSource>(IList<TSource> list) {
			return Currying.MergeAll(list);
		}

		public static dynamic MergeAll(RamdaPlaceholder list = null) {
			return Currying.MergeAll(list);
		}
	}
}