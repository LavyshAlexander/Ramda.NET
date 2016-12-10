﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace Ramda.NET.Tests
{
    public static class Extension
    {
        public static bool ContentEquals(this IDictionary<string, object> dictionary, IDictionary<string, object> otherDictionary) {
            return otherDictionary.OrderBy(kvp => kvp.Key)
                                  .SequenceEqual(dictionary.OrderBy(kvp => kvp.Key), (a, b) => {
                                      var typedA = (KeyValuePair<string, object>)a;
                                      var typedB = (KeyValuePair<string, object>)b;
                                      var typedAIsAnonymous = false;
                                      var typedBIsAnonymous = false;

                                      if (typedA.Value.IsDictionary() && typedB.Value.IsDictionary()) {
                                          var innerA = typedA.Value as IDictionary<string, object>;
                                          var innerB = typedB.Value as IDictionary<string, object>;

                                          return innerA.ContentEquals(innerB);
                                      }

                                      typedAIsAnonymous = typedA.Value.IsAnonymousType();
                                      typedBIsAnonymous = typedB.Value.IsAnonymousType();

                                      if (typedAIsAnonymous || typedBIsAnonymous) {
                                          ExpandoObject innerA = typedA.Value.ToDynamic();
                                          ExpandoObject innerB = typedB.Value.ToDynamic();

                                          return innerA.ContentEquals(innerB);
                                      }

                                      if (typedA.Value.IsList() && typedB.Value.IsList()) {
                                          var innerA = typedA.Value as IList;
                                          var innerB = typedB.Value as IList;

                                          return innerA.SequenceEqual(innerB, (_a, _b) => _a.Equals(_b));
                                      }

                                      return typedA.Value.Equals(typedB.Value);
                                  });
        }

        public static bool ContentEquals(this IDictionary<string, object> dictionary, ExpandoObject expando) {
            var otherDictionary = expando as IDictionary<string, object>;

            return dictionary.ContentEquals(otherDictionary);
        }

        public static bool ContentEquals(this ExpandoObject dictionary, ExpandoObject expando) {
            var otherDictionary = expando as IDictionary<string, object>;

            return ((IDictionary<string, object>)dictionary).ContentEquals(otherDictionary);
        }

        public static dynamic ToDynamic(this object value) {
            if (value.IsExpandoObject()) {
                return value;

            }

            IDictionary<string, object> expando = new ExpandoObject();

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(value.GetType())) {
                expando.Add(property.Name, property.GetValue(value));
            }

            return expando as ExpandoObject;
        }

        public static ExpandoObject ToExpando(this object value) {
            return value.ToDynamic();
        }
    }
}