using System;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var morning_start = TimeSpan.Parse("9:00");
            var morning_end = TimeSpan.Parse("12:00");
            var day_end = TimeSpan.Parse("15:00");
            var evening_end = TimeSpan.Parse("22:00");
            var time_now = DateTime.Now.TimeOfDay;

            bool in_rangeM = morning_start <= time_now & time_now <= morning_end;
            if (in_rangeM == true)
            {
                Console.WriteLine("Good morning, guys");
            }

            bool in_rangeD = morning_end <= time_now & time_now <= day_end;
            if (in_rangeD == true)
            {
                Console.WriteLine("Good day, guys");
            }

            bool in_rangeE = day_end <= time_now & time_now <= evening_end;
            if (in_rangeE == true)
            {
                Console.WriteLine("Good evening, guys");
            }
        }
    }
}
