﻿using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Ramda.NET
{
    internal static partial class Core
    {
        internal static TArg CastTo<TArg>(this object arg) {
            if (typeof(IConvertible).IsAssignableFrom(arg.GetType())) {
                return (TArg)Convert.ChangeType(arg, typeof(TArg));
            }

            return (TArg)arg;
        }

        internal static Func<object[], bool> Complement(Func<object[], bool> fn) {
            return (arguments => !fn.Invoke(arguments));
        }

        internal static IList Concat(IList set1, IList set2 = null) {
            var result = new List<object>();

            if (set1 != null) {
                foreach (var item in set1) {
                    result.Add(item);
                }
            }

            if (set2 != null) {
                foreach (var item in set2) {
                    result.Add(item);
                }
            }

            return result;
        }

        private static bool ContainsWith(Func<object, object, bool> predicate, object x, IList list) {
            foreach (var item in list) {
                if (predicate(x, item)) {
                    return true;
                }
            }

            return false;
        }

        private static IList Filter(Func<object, bool> fn, IList list) {
            var result = new List<object>();

            foreach (var item in list) {
                if (fn(item)) {
                    result.Add(item);
                }
            }

            return result;
        }

        private static IList Slice(IList arguments, int from = int.MinValue, int to = int.MinValue) {
            if (from == int.MinValue) {
                return Slice(arguments, 0, arguments.Count);
            }
            else if (to == int.MinValue) {
                return Slice(arguments, from, arguments.Count);
            }
            else {
                IList result;
                var len = Math.Max(0, Math.Min(arguments.Count, to) - from);

                if (arguments.IsFixedSize) {
                    result = new object[len];
                    Array.Copy((object[])arguments, from, (object[])result, 0, len);
                }
                else {
                    var list = new List<object>();

                    foreach (var item in arguments) {
                        list.Add(item);
                    }

                    result = list.Skip(from).Take(len).ToList();
                }

                return result;
            }
        }

        internal static Func<object, dynamic> Dispatchable(Currying.LambdaN transducerFunction, Delegate fn) {
            return arg1 => {
                if (Currying.FunctionArity(arg1) == 0) {
                    return fn.DynamicInvoke(new object[0]);
                }

                return fn.DynamicInvoke(arg1);
            };
        }

        internal static Func<object, object, dynamic> Dispatchable2(string methodName, Currying.LambdaN transducerFunction, Delegate fn) {
            return (arg1, arg2) => {
                var length = Currying.FunctionArity(arg1, arg2);

                if (length == 0) {
                    return fn.DynamicInvoke(new object[0]);
                }

                if (!arg2.GetType().IsArray) {
                    var members = arg2.GetType().GetMember(methodName);

                    if (members.Length == 1) {
                        var member = members[0];

                        if (member.MemberType == MemberTypes.Method) {
                            return ((MethodInfo)member).Invoke(arg2, new[] { arg1 });
                        }
                    }

                    if (arg2 is ITransducer) {
                        var transducer = transducerFunction(arg1);

                        return transducer(arg2);
                    }
                }

                return fn.DynamicInvoke(arg1, arg2);
            };
        }

        private static IList DropLastWhile(Func<object, bool> predicate, object x, IList list) {
            var idx = list.Count - 1;

            while (idx >= 0 && predicate(list[idx])) {
                idx -= 1;
            }

            return Slice(list, 0, idx + 1);
        }

        internal static IList Aperture(int length, IList list) {
            var idx = 0;
            var limit = list.Count - (length - 1);
            IList acc = null;

            limit = limit >= 0 ? limit : 0;
            acc = list.IsFixedSize ? (IList)new object[limit] : new List<object>(limit);

            while (idx < limit) {
                acc[idx] = Slice(list, idx, idx + length);
                idx += 1;
            }

            return acc;
        }
    }
}
