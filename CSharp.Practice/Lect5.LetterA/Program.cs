using System;
using System.Linq;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write text: ");
            string text = Console.ReadLine();
            int int_text = text.Length;
            int letter_A = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    letter_A++;
                }
            }
            Console.WriteLine("Number of letter \"A\":" + letter_A);
        }
    }
}
