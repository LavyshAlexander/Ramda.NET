﻿// <autogenerated>
//   This file was generated by T4 code generator MathMod.tt.
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
		/// mathMod behaves like the modulo operator should mathematically, unlike the`%` operator (and by extension, R.modulo). So while "-17 % 5" is -2,mathMod(-17, 5) is 3. mathMod requires Integer arguments, and returns NaNwhen the modulus is zero or negative.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="m">The dividend.</param>
		/// <param name="p">the modulus.</param>
		/// <returns>The result of `b mod a`.</returns>
		public static dynamic MathMod(int m, uint p) {
			return Currying.MathMod(m, p);
		}

		/// <summary>
		/// mathMod behaves like the modulo operator should mathematically, unlike the`%` operator (and by extension, R.modulo). So while "-17 % 5" is -2,mathMod(-17, 5) is 3. mathMod requires Integer arguments, and returns NaNwhen the modulus is zero or negative.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="m">The dividend.</param>
		/// <param name="p">the modulus.</param>
		/// <returns>The result of `b mod a`.</returns>
		public static dynamic MathMod(RamdaPlaceholder m, uint p) {
			return Currying.MathMod(m, p);
		}

		/// <summary>
		/// mathMod behaves like the modulo operator should mathematically, unlike the`%` operator (and by extension, R.modulo). So while "-17 % 5" is -2,mathMod(-17, 5) is 3. mathMod requires Integer arguments, and returns NaNwhen the modulus is zero or negative.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="m">The dividend.</param>
		/// <param name="p">the modulus.</param>
		/// <returns>The result of `b mod a`.</returns>
		public static dynamic MathMod(int m, RamdaPlaceholder p = null) {
			return Currying.MathMod(m, p);
		}

		/// <summary>
		/// mathMod behaves like the modulo operator should mathematically, unlike the`%` operator (and by extension, R.modulo). So while "-17 % 5" is -2,mathMod(-17, 5) is 3. mathMod requires Integer arguments, and returns NaNwhen the modulus is zero or negative.
		/// <para />
		/// sig: Number -> Number -> Number
		/// </summary>
		/// <param name="m">The dividend.</param>
		/// <param name="p">the modulus.</param>
		/// <returns>The result of `b mod a`.</returns>
		public static dynamic MathMod(RamdaPlaceholder m = null, RamdaPlaceholder p = null) {
			return Currying.MathMod(m, p);
		}
	}
}