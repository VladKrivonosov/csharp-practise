using System;

namespace taskLection7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
        }

        static void Task_1()
        {
            string[] array1 = new string[] { };
        }

        static void Task_2()
        {
            object[] myArray = new object[3] { 32, "A", "Hello" };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            int addNumber = Convert.ToInt32(myArray[0]);
            addNumber += 10;
            myArray[0] = addNumber;

            string addText = Convert.ToString(myArray[2]);
            addText += ", gues !";
            myArray[2] = addText;

            for (int i = 0; i < 3; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }

        static void Task_3()
        {
            Random randomNumbers = new Random();
            int[] randomArray = new int[13];
            Console.WriteLine();

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNumbers.Next(0, 100);
                Console.Write(randomArray[i] + " ");
            }

            int checkNumber = 0;
            for (int i = 0; i < randomArray.Length-1; i++)
            {
                if (randomArray[i] >= checkNumber)
                {
                    checkNumber = randomArray[i];
                }
            }

            Console.WriteLine($"\nMax numebr from array: {checkNumber}");
        }

    }
}

