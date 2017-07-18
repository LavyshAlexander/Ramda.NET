﻿// <autogenerated>
//   This file was generated by T4 code generator Transpose.tt.
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
		/// Transposes the rows and columns of a 2D list.When passed a list of `n` lists of length `x`,returns a list of `x` lists of length `n`.
		/// <para />
		/// sig: [[a]] -> [[a]]
		/// </summary>
		/// <param name="list">A 2D list</param>
		/// <returns>A 2D list</returns>
		public static dynamic Transpose<TArg>(TArg[][] list) {
			return Currying.Transpose(list);
		}

		/// <summary>
		/// Transposes the rows and columns of a 2D list.When passed a list of `n` lists of length `x`,returns a list of `x` lists of length `n`.
		/// <para />
		/// sig: [[a]] -> [[a]]
		/// </summary>
		/// <param name="list">A 2D list</param>
		/// <returns>A 2D list</returns>
		public static dynamic Transpose(RamdaPlaceholder list = null) {
			return Currying.Transpose(list);
		}
	}
}