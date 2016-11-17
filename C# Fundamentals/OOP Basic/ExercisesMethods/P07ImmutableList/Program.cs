using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P07ImmutableList
{
    public class ImmutableList
    {
        public List<int> immutableNumbers;

        public ImmutableList(List<int> immutableNumbers)
        {
            this.immutableNumbers = new List<int>();
        }

        public ImmutableList Get()
        {
            List<int> newCollection = new List<int>(this.immutableNumbers);
            ImmutableList newImmutable = new ImmutableList(newCollection);

            return newImmutable;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }
}
