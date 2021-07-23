using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExtensionMethods.ValuePersistence
{
    public static class ExtensionMethods
    {
        private static Dictionary<WeakReference, object> tagsDictionary = new();

        public static object GetTag(this object obj)
        {
            WeakReference weakReferenceOfObject = tagsDictionary.Keys.FirstOrDefault(k => k.IsAlive && k.Target == obj);
            return weakReferenceOfObject != null ? tagsDictionary[weakReferenceOfObject] : null;
        }

        public static void SetTag(this object obj, object tag)
        {
            WeakReference weakReferenceOfObject = tagsDictionary.Keys.FirstOrDefault(k => k.IsAlive && k.Target == obj);
            if (weakReferenceOfObject is not null)
            {
                tagsDictionary[weakReferenceOfObject] = tag;
            }
            else
            {
                tagsDictionary[new WeakReference(obj)] = tag;
            }
        }

    }
}
