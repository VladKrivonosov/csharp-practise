using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            //int32
            arrayList.Add(45); //false
            arrayList.Add(true); // true unboxing
            arrayList.Add("Hello"); // true unboxing
            arrayList.Add(23.45); // true 
        }
    }
}
