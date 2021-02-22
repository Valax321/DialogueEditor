using System.Collections;
using System.Collections.Generic;

namespace Valax321.DialogueEditor
{
    public static class CollectionUtils
    {
        public static void AddRange<T>(this ICollection<T> collection, params T[] args)
        {
            foreach (var arg in args)
            {
                collection.Add(arg);
            }
        }

        public static void AddRange(this IList collection, params object[] args)
        {
            foreach (var o in args)
            {
                collection.Add(o);
            }
        }
    }
}