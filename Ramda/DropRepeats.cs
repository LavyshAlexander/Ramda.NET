﻿// <autogenerated>
//   This file was generated by T4 code generator DropRepeats.tt.
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
		public static dynamic DropRepeats<TSource>(IList<TSource> list) {
			return Currying.DropRepeats(list);
		}

		public static dynamic DropRepeats(RamdaPlaceholder list = null) {
			return Currying.DropRepeats(list);
		}
	}
}