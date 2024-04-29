using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS7
{
    internal class SomeClass<T>
    {
        protected T[] somemass;
        public SomeClass()
        {
            this.somemass = new T[3];
        }
        public SomeClass(int length, params T[] values)
        {
            this.somemass = new T[length];
            for (int i = 0; i < this.somemass.Length; i++)
            {
                this.somemass[i] = values[i];
            }
        }
        public static void toAdd(SomeClass<T> someclass, T element)
        {
            int j = 0;
            T[] newArray = new T[someclass.somemass.Length + 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < someclass.somemass.Length)
                {
                    newArray[i] = someclass.somemass[i];
                }
                else if (i >= someclass.somemass.Length)
                {
                    newArray[i] = element;
                }
            }
            someclass.somemass = newArray;
            foreach (T i in someclass.somemass)
            {
                Console.WriteLine(i);
            }
        }
        public static void toDelete(SomeClass<T> someclass, int index)
        {
            T[] newArray = new T[someclass.somemass.Length - 1];
            for (int i = 0; i < someclass.somemass.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = someclass.somemass[i];
                }
                else if (i > index)
                {
                    newArray[i - 1] = someclass.somemass[i];
                }
            }
            someclass.somemass = newArray;
            foreach (T i in someclass.somemass)
            {
                Console.WriteLine(i);
            }
        }
        public static T getByIndex(SomeClass<T> someclass, int index)
        {
            return someclass.somemass[index];
        }
        public static int getLength(SomeClass<T> someclass)
        {
            return someclass.somemass.Length;
        }
    }
}
