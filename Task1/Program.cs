using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short short_Sbyte = 45;
            object box_short_Sbyte = short_Sbyte;
            SByte unboxing_short_Sbyte = (SByte)(short)box_short_Sbyte;
            Console.WriteLine("{0},{1}",unboxing_short_Sbyte,unboxing_short_Sbyte.GetType());
        }
    }
}
