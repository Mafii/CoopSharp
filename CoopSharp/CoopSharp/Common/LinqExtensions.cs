using System;
using System.Collections.Generic;

namespace CoopSharp.Common
{
  public static class LinqExtensions
  {
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
      foreach (T item in source)
      {
        action(item);
      }
    }

    public static void ForEach<TKey, TValue>(this IDictionary<TKey, TValue> source, Action<TKey, TValue> action) 
      => source.ForEach(item => action(item.Key, item.Value));
  }
}