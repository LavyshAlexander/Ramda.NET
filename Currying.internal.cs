﻿using System;
using System.Linq;
using Sys = System;
using System.Dynamic;
using System.Reflection;
using System.Collections;
using static Ramda.NET.R;
using System.Threading.Tasks;
using System.Linq.Expressions;
using static Ramda.NET.Lambda;
using System.Collections.Generic;
using Object = Ramda.NET.ReflectionExtensions;

namespace Ramda.NET
{
    internal static partial class Currying
    {
        private static Delegate Complement(Delegate fn) {
            return new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                return !(bool)fn.Invoke(arguments);
            });
        }

        private static bool ContainsWith(Func<object, object, bool> predicate, object x, IList list) {
            foreach (var item in list) {
                if (predicate(x, item)) {
                    return true;
                }
            }

            return false;
        }

        private static IList FilterInternal(Func<object, bool> fn, IList list) {
            var result = new List<object>();

            foreach (var item in list) {
                if (fn(item)) {
                    result.Add(item);
                }
            }

            return result;
        }

        internal static IReduced ForceReduced(object x) => new ReducedImpl(x);

        private static bool HasInternal(string prop, object obj) {
            if (obj.IsDictionary()) {
                var dictionary = obj as IDictionary;
                IDictionary<string, object> expandoDictionary;

                if (dictionary.IsNotNull()) {
                    return dictionary.Contains(prop);
                }

                expandoDictionary = obj as IDictionary<string, object>;

                if (expandoDictionary.IsNotNull()) {
                    return expandoDictionary.ContainsKey(prop);
                }
            }

            return obj.TryGetMemberInfo(prop).IsNotNull();
        }

        internal static TValue IdentityInternal<TValue>(TValue x) => x;

        private static object[] MapInternal(Delegate fn, IList functor) {
            var idx = 0;
            var len = functor.Count;
            var result = new object[len];

            while (idx < len) {
                result[idx] = fn.Invoke(functor[idx]);
                idx += 1;
            }

            return result;
        }

        private static Array OfInternal(object x) {
            var type = x.GetType();
            var list = type.CreateNewList<IList>();

            list.Insert(0, x);

            return list.ToArray<Array>();
        }

        private static LambdaN PipeInternal(Delegate f, Delegate g) {
            return new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                return g.Invoke(f.Invoke(arguments));
            });
        }

        private static LambdaN PipePInternal(Delegate f, Delegate g) {
            return new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                return Task<object>.Factory.StartNew(() => f.Invoke(arguments)).ContinueWith(result => g.Invoke(result));
            });
        }

        internal static IReduced ReducedInternal(object x) {
            var reduced = x as IReduced;

            return reduced.IsNotNull() && reduced.IsReduced ? reduced : new ReducedImpl(x);
        }

        private static IList ApertureInternal(int length, IList list) {
            var idx = 0;
            var limit = list.Count - (length - 1);
            IList acc = null;

            limit = limit >= 0 ? limit : 0;
            acc = list.IsArray() ? (IList)new object[limit] : new List<object>(limit);

            while (idx < limit) {
                acc[idx] = list.Slice(idx, idx + length);
                idx += 1;
            }

            return acc;
        }

        private static object Assign(params object[] objectN) {
            return ObjectAssigner.Assign(new ExpandoObject(), objectN);
        }

        private static object Assign(IList list) {
            return ObjectAssigner.Assign(new ExpandoObject(), list.Cast<object>().ToArray());
        }

        private static LambdaN CheckForMethod1(string methodName, Delegate fn) {
            return Currying.Curry1<IList, IList>(list => {
                return (IList)CheckForMethodN(methodName, fn, list);
            });
        }

        private static Func<object, object, object> CheckForMethod2(string methodName, Delegate fn) {
            return new Func<object, object, object>((arg1, arg2) => CheckForMethodN(methodName, fn, arg1, arg2));
        }

        private static Func<TArg1, TArg2, TArg3, TResult> CheckForMethod3<TArg1, TArg2, TArg3, TResult>(string methodName, Func<TArg1, TArg2, TArg3, TResult> fn) {
            return (arg1, arg2, arg3) => (TResult)CheckForMethodN(methodName, fn, arg1, arg2, arg3);
        }

        private static object CheckForMethodN(string methodName, Delegate fn, params object[] arguments) {
            object obj;
            object member;
            var invokeFn = false;
            var length = arguments.Length;

            if (length == 0) {
                return fn.DynamicInvoke(new object[0]);
            }

            obj = arguments[length - 1];
            member = obj.TryGetMemberInfo(methodName);
            invokeFn = member.IsNotNull() && !member.IsFunction();

            if (invokeFn || obj.IsList()) {
                return fn.Invoke(arguments);
            }

            return ((Delegate)member).DynamicInvoke(obj, arguments.Slice(0, length - 1));
        }

        private static Lambda2 Dispatchable2(string methodName, Delegate xf, Delegate fn) {
            return new Lambda2((arg1, arg2) => {
                var arguments = Currying.Arity(arg1, arg2);

                return Dispatchable(methodName, xf, fn, arguments);
            });
        }

        private static Func<object, object, object, object, object> Dispatchable4(string methodName, Delegate xf, Delegate fn) {
            return new Func<object, object, object, object, object>((arg1, arg2, arg3, arg4) => {
                var arguments = Currying.Arity(arg1, arg2, arg3, arg4);

                return Dispatchable(methodName, xf, fn, arguments);
            });
        }

        private static object Dispatchable(string methodName, Delegate xf, Delegate fn, params object[] arguments) {
            object obj;

            if (arguments.Length == 0) {
                return fn.Invoke(new object[0]);
            }

            obj = arguments[arguments.Length - 1];
            if (!obj.IsArray()) {
                var args = (object[])arguments.Slice(0, arguments.Length - 1);
                var member = GetMapFunction(obj);

                if (member.IsNotNull()) {
                    return member.Invoke(args);
                }

                if (obj is ITransformer) {
                    var transformer = (dynamic)xf.Invoke(args);

                    return transformer(obj);
                }
            }

            return fn.Invoke(arguments);
        }

        private static Delegate GetMapFunction(this object obj) {
            Delegate @delegate = null;

            obj.GetMemberWhen<MemberInfo>("Map", m => {
                switch (m.MemberType) {
                    case MemberTypes.Method:
                        Type delegateType = null;
                        var method = (MethodInfo)m;
                        IEnumerable<Type> @params = method.GetParameters().Select(p => p.ParameterType);

                        if (!method.ReturnType.Equals(typeof(void))) {
                            @params = @params.Concat(new[] { method.ReturnType });
                        }

                        delegateType = Expression.GetFuncType(@params.ToArray());

                        @delegate = Delegate.CreateDelegate(delegateType, method);
                        break;
                    case MemberTypes.Property:
                        var prop = (PropertyInfo)m;

                        @delegate = prop.GetGetMethod(true).Invoke(obj, null) as Delegate;
                        break;
                    default:
                        return false;
                }

                return true;
            });

            return @delegate;
        }

        private static IList DropLastWhileInternal(Delegate pred, IList list) {
            var idx = list.Count - 1;

            while (idx >= 0 && (bool)pred.Invoke(list[idx])) {
                idx -= 1;
            }

            return list.Slice(0, idx + 1);
        }

        private readonly static dynamic XAll = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XAll((o => (bool)f.Invoke(o)), xf));

        private readonly static dynamic XAny = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XAny(f, xf));

        private readonly static dynamic XAperture = Curry2<int, ITransformer, ITransformer>((n, xf) => new XAperture(n, xf));

        private readonly static dynamic XDrop = Curry2<int, ITransformer, ITransformer>((n, xf) => new XDrop(n, xf));

        private readonly static dynamic XDropLast = Curry2<int, ITransformer, ITransformer>((n, xf) => new XDropLast(n, xf));

        private readonly static dynamic XDropRepeatsWith = Curry2<Func<object, object, bool>, ITransformer, ITransformer>((pred, xf) => new XDropRepeatsWith(pred, xf));

        private readonly static dynamic XDropWhile = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XDropWhile(f, xf));

        private readonly static dynamic XFilter = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XFilter(f, xf));

        private readonly static dynamic XFind = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XFind(f, xf));

        private readonly static dynamic XFindIndex = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XFindIndex(f, xf));

        private readonly static dynamic XFindLast = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XFindLast(f, xf));

        private readonly static dynamic XFindLastIndex = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XFindLastIndex(f, xf));

        private readonly static dynamic XMap = Curry2<Func<object, object>, ITransformer, ITransformer>((f, xf) => new XMap(f, xf));

        private readonly static dynamic XReduceBy = CurryNInternal(4, new object[0], new Func<Func<object, object, object>, IList, Func<object, string>, ITransformer, ITransformer>((valueFn, valueAcc, keyFn, xf) => {
            return new XReduceBy(valueFn, valueAcc, keyFn, xf);
        }));

        private readonly static dynamic XTake = Curry2<int, ITransformer, ITransformer>((n, xf) => new XTake(n, xf));

        private readonly static dynamic XTakeWhile = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XTakeWhile(f, xf));

        private readonly static dynamic XDropLastWhile = Curry2<Func<object, bool>, ITransformer, ITransformer>((f, xf) => new XDropLstWhile(f, xf));

        private readonly static dynamic XChain = Curry2<Delegate, ITransformer, object>((f, xf) => Map(f, new XFlatCat(xf)));

        internal class ComparerFactory : IComparer
        {
            private Func<object, object, int> comparator;

            internal ComparerFactory(Func<object, object, int> comparator) {
                this.comparator = comparator;
            }

            public int Compare(object x, object y) {
                return comparator(x, y);
            }
        }

        private static Tuple<object, IList> MapAccumInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Delegate fn, object acc, IList list) {
            var tuple = R.Tuple.Create(acc, null);
            IList result = new object[list.Count];

            while (loopPredicate(from)) {
                tuple = (R.Tuple)fn.DynamicInvoke(tuple.Item1, list[from]);
                result[from] = tuple.Item1;
                from += indexerAcc;
            }

            return Sys.Tuple.Create(tuple.Item1, result);
        }

        private static object FindInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Func<object, bool> fn, IList list) {
            var idx = from;

            while (loopPredicate(idx)) {
                if (fn(list[idx])) {
                    return list[idx];
                }

                idx += indexerAcc;
            }

            return null;
        }

        private static int FindIndexInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Func<object, bool> fn, IList list) {
            var idx = from;

            while (loopPredicate(idx)) {
                if (fn(list[idx])) {
                    return idx;
                }

                idx += indexerAcc;
            }

            return -1;
        }

        private static object InternalIfElse(Delegate condition, Delegate onTrue, Delegate onFalse, params object[] arguments) {
            return (bool)((LambdaN)condition).Invoke(arguments) ? ((LambdaN)onTrue).Invoke(arguments) : ((LambdaN)onFalse).Invoke(arguments);
        }

        private static object InternalEvolve(IDictionary<string, object> transformations, object target) {
            IDictionary<string, object> result = new ExpandoObject();

            foreach (var keyValue in target.ToMemberDictionary()) {
                object transformation;
                var key = keyValue.Key;
                var value = keyValue.Value;

                if (transformations.TryGetValue(key, out transformation)) {
                    if (transformation.IsFunction()) {
                        result[key] = ((Delegate)transformation).Invoke(value);
                        continue;
                    }
                    else if (value is object) {
                        if (!transformation.IsDictionary()) {
                            transformation = transformation.ToMemberDictionary();
                        }

                        result[key] = InternalEvolve((IDictionary<string, object>)transformation, value);
                        continue;
                    }
                }

                result[key] = value;
            }

            return result;
        }

        private static object InternalDissocPath(IList path, object obj) {
            switch (path.Count) {
                case 0:
                    return obj;
                case 1:
                    return Dissoc(path[0], obj);
                default:
                    var head = (string)path[0];
                    var tail = Slice(path, 1);
                    var headValue = obj.Member(head);

                    return headValue.IsNull() ? obj : Assoc(head, InternalDissocPath(tail, headValue), obj);
            }
        }

        private static bool AllOrAny(Delegate fn, IList list, bool returnValue) {
            foreach (var item in list) {
                if ((bool)fn.Invoke(item) == returnValue) {
                    return returnValue;
                }
            }

            return !returnValue;
        }

        private static IDictionary<string, object> PickIntrenal(IList<string> names, object obj, bool setIfNull = false) {
            IDictionary<string, object> result = new ExpandoObject();

            foreach (var name in names) {
                object member;

                if (!Object.TryGetMember(name, obj, out member) && !setIfNull) {
                    continue;
                }

                result[name] = member;
            }

            return result;
        }

        private static IList SortInternal(IList list, IComparer comparer) {
            if (list.IsArray()) {
                Array.Sort((Array)list, comparer);

                return list;
            }

            var array = list.ToArray<Array>();
            Array.Sort(array, comparer);

            return array.CreateNewList(array);
        }

        private static IList TakeWhileInternal(int from, int indexerAcc, Func<int, bool> loopPredicate, Delegate fn, IList list, Func<int, int> sliceFrom, Func<int, int> sliceTo) {
            var idx = from;

            while (loopPredicate(idx) && (bool)fn.DynamicInvoke(list[idx])) {
                idx += indexerAcc;
            }

            return list.Slice(sliceFrom(idx), sliceTo(idx));
        }

        private static IList[] ZipInternal(IList a, IList b, int len, Func<IList, int, object> valAResolver = null) {
            var idx = 0;
            var rv = new List<IList>();

            while (idx < len) {
                IList pair;
                var valB = b[idx];
                var valA = valAResolver?.Invoke(a, idx) ?? a[idx];
                var typeA = valA.GetType();

                if (typeA.Equals(valB.GetType())) {
                    pair = typeA.CreateNewList<IList>();
                    pair.Add(valA);
                    pair.Add(valB);
                    pair = pair.ToArray<Array>(typeA);
                }
                else {
                    pair = new object[] { valA, valB };
                }

                rv.Add(pair);
                idx += 1;
            }

            return rv.ToArray();
        }

        private static bool IsPlaceholder(object param) {
            return param != null && R.__.Equals(param);
        }

        private static LambdaN CurryNInternal(int length, object[] received, Delegate fn) {
            return new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var argsIdx = 0;
                var left = length;
                var combinedIdx = 0;
                var combined = new List<object>();
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                var argumentsLength = arguments?.Length ?? 0;

                while (combinedIdx < received.Length || argsIdx < argumentsLength) {
                    object result = null;

                    if (combinedIdx < received.Length && (!IsPlaceholder(received[combinedIdx]) || argsIdx >= argumentsLength)) {
                        result = received[combinedIdx];
                    }
                    else {
                        result = arguments[argsIdx];
                        argsIdx += 1;
                    }

                    combined.Insert(combinedIdx, result);

                    if (!IsPlaceholder(result)) {
                        left -= 1;
                    }

                    combinedIdx += 1;
                }

                return left <= 0 ? fn.Invoke(combined.ToArray()) : Arity(left, CurryNInternal(length, combined.ToArray(), fn));
            });
        }

        private static Functor IdentityFunctor(object x) {
            return new Functor {
                Value = x,
                Map = new Func<Delegate, Functor>(f => {
                    return IdentityFunctor(f.DynamicInvoke(x));
                })
            };
        }

        private static Functor Const(object x) {
            var functor = new Functor { Value = x };

            functor.Map = new Func<Delegate, Functor>(f => {
                return functor;
            });

            return functor;
        }

        private static Delegate CreatePartialApplicator(Delegate concat) {
            return Curry2<Delegate, IList, Delegate>((fn, args) => {
                return Arity(Math.Max(0, fn.Arity() - args.Count), new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                    var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    var concatedArgs = (IList)concat.Invoke(args, arguments);

                    return fn.InvokeWithArray(concatedArgs.ToArray<object[]>(typeof(object)));
                }));
            });
        }

        private static IList DropLastInternal(int n, IList xs) {
            return Take(n < xs.Count ? xs.Count - n : 0, xs);
        }

        private static bool EqualsInternal(object a, object b) {
            Type typeA;
            bool bothEnumerables;
            Type typeB = b.GetType();
            var typeofString = typeof(string);

            if (Identical(a, b)) {
                return true;
            }

            if (a.IsNull() || b.IsNull()) {
                return false;
            }

            typeA = a.GetType();
            bothEnumerables = a.IsEnumerable() && !typeA.Equals(typeofString) && b.IsEnumerable() && !typeA.Equals(typeofString);

            if (!typeA.Equals(typeB) && !bothEnumerables) {
                var bothAnonymous = a.IsAnonymousType() && b.IsAnonymousType();

                if (!bothAnonymous) {
                    return false;
                }
            }

            if (bothEnumerables) {
                return ((IEnumerable)a).SequenceEqual((IEnumerable)b, EqualsInternal);
            }

            if (typeA.Equals(typeB) && (typeA.IsPrimitive || typeA.Equals(typeof(string)) || typeA.Equals(typeof(DateTime)) || typeA.Equals(typeof(decimal)) || typeA.Equals(typeof(Guid)))) {
                return false;
            }

            return MemberwiseComparer.Compare(a, b);
        }

        private static Func<IList, IList> MakeFlat(bool recursive) {
            return list => Flatt(list, recursive);
        }

        private static IList Flatt(IList list, bool recursive) {
            var result = new ArrayList();

            foreach (var item in list) {
                if (IsArrayLike(item)) {
                    var itemAsList = (IList)item;
                    var value = recursive ? Flatt(itemAsList, recursive) : itemAsList;
                    var list2 = itemAsList.CreateNewList(type: typeof(object));

                    foreach (var item2 in value) {
                        result.Add(item2);
                    }
                }
                else {
                    result.Add(item);
                }
            }

            return result.ToArray<IList>();
        }

        internal static object ReduceInternal(object fn, object acc, object list) {
            ITransformer transformer = null;

            if (fn.IsFunction()) {
                transformer = new XWrap((Delegate)fn);
            }

            if (list.IsEnumerable()) {
                return IterableReduce(transformer, acc, (IEnumerable)list);
            }

            if (list.HasMemberWhere("Reduce", t => t.IsFunction())) {
                return MethodReduce(transformer, acc, list);
            }

            throw new ArgumentException("Reduce: list must be array or iterable");
        }

        private static object IterableReduce(ITransformer xf, object acc, IEnumerable list) {
            IReduced reduced;

            foreach (var item in list) {
                acc = xf.Step(acc, item);
                reduced = acc as IReduced;

                if (reduced.IsNotNull()) {
                    acc = reduced.Value;
                    break;
                }
            }

            return xf.Result(acc);
        }

        private static object MethodReduce(ITransformer xf, object acc, dynamic obj) {
            return xf.Result(obj.Reduce(new Func<object, object, object>(xf.Step), acc));
        }

        private static ITransformer StepCat(object obj) {
            Type objType;
            var transformer = obj as ITransformer;

            if (transformer.IsNotNull()) {
                return transformer;
            }

            if (IsArrayLike(obj)) {
                return new StepCatArray();
            }

            objType = obj.GetType();

            if (objType.Equals(typeof(string))) {
                return transformer;
            }

            if (objType.Equals(typeof(object))) {
                return transformer;
            }

            throw new ArgumentException($"Cannot create transformer for {obj.GetType().Name}");
        }

        private static LambdaN AnyOrAllPass(IList preds, bool comparend) {
            return new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                foreach (Delegate pred in preds) {
                    if ((bool)pred.Invoke(arguments) == comparend) {
                        return comparend;
                    }
                }

                return !comparend;
            });
        }

        private static object ApplySpecInternal(object spec) {
            spec = Map(new Func<object, object>(v => v.IsFunction() ? v : ApplySpecInternal(v)), spec);

            return CurryN(Reduce(Max, 0, Pluck("Length", Values(spec))), new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
                var arguments = Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

                return Map(new Func<object, object>(f => Apply(f, arguments)), spec);
            }));
        }

        private static object ArrayOf = new LambdaN((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => {
            return Arity(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        });

        private static bool ContainsInternal(object item, object list) {
            if (list.IsList()) {
                return ((IList)list).Contains(item);
            }

            var contains = list.GetMemberWhen<MethodInfo>("Contains", m => m.MemberType == MemberTypes.Method);

            if (contains.IsNotNull()) {
                return (bool)contains.Invoke(list, new[] { item });
            }

            return false;
        }
    }
}
