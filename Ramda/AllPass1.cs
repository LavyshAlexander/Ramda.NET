﻿// <autogenerated>
//   This file was generated by T4 code generator AllPass.tt.
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
		public static dynamic AllPass<TSource>(IList<Func<TSource, bool>> preds) {
			return Currying.AllPass(preds);
		}

		public static dynamic AllPass(RamdaPlaceholder preds = null) {
			return Currying.AllPass(preds);
		}
	}
}