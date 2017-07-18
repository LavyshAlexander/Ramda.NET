﻿// <autogenerated>
//   This file was generated by T4 code generator MergeWith.tt.
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
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> fn, object l, object r) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(RamdaPlaceholder fn, object l, object r) {
			return Currying.MergeWith(fn, l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> fn, RamdaPlaceholder l, object r) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> fn, object l, RamdaPlaceholder r = null) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> fn, RamdaPlaceholder l = null, RamdaPlaceholder r = null) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(dynamic fn, RamdaPlaceholder l, object r) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(dynamic fn, object l, RamdaPlaceholder r = null) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(dynamic fn, RamdaPlaceholder l = null, RamdaPlaceholder r = null) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(dynamic fn, object l, object r) {
			return Currying.MergeWith(Delegate(fn), l, r);
		}

		/// <summary>
		/// Creates a new object with the own properties of the two provided objects. Ifa key exists in both objects, the provided function is applied to the valuesassociated with the key in each object, with the result being used as thevalue associated with the key in the returned object. The key will beexcluded from the returned object if the resulting value is `undefined`.
		/// <para />
		/// sig: (a -> a -> a) -> {a} -> {a} -> {a}
		/// </summary>
		/// <param name="fn">first</param>
		/// <param name="l">second</param>
		/// <param name="r">third</param>
		/// <returns>Object</returns>
		/// <see cref="R.Merge"/>
		/// <see cref="R.MergeWithKey"/>
		public static dynamic MergeWith(RamdaPlaceholder fn = null, RamdaPlaceholder l = null, RamdaPlaceholder r = null) {
			return Currying.MergeWith(fn, l, r);
		}
	}
}