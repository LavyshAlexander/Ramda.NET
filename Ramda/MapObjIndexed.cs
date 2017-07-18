﻿// <autogenerated>
//   This file was generated by T4 code generator MapObjIndexed.tt.
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
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed<TTarget, TReturn>(Func<TTarget, TReturn> fn, TTarget obj) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		/// <summary>
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed<TTarget>(RamdaPlaceholder fn, TTarget obj) {
			return Currying.MapObjIndexed(fn, obj);
		}

		/// <summary>
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed<TTarget, TReturn>(Func<TTarget, TReturn> fn, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		/// <summary>
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed(dynamic fn, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		/// <summary>
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed<TTarget>(dynamic fn, TTarget obj) {
			return Currying.MapObjIndexed(Delegate(fn), obj);
		}

		/// <summary>
		/// An Object-specific version of `map`. The function is applied to threearguments: *(value, key, obj)*. If only the value is significant, use`map` instead.
		/// <para />
		/// sig: ((*, String, Object) -> *) -> Object -> Object
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="obj">second</param>
		/// <returns>Object</returns>
		/// <see cref="R.Map"/>
		public static dynamic MapObjIndexed(RamdaPlaceholder fn = null, RamdaPlaceholder obj = null) {
			return Currying.MapObjIndexed(fn, obj);
		}
	}
}