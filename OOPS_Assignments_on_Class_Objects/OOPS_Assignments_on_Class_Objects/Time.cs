using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Time
    {
        private int Hours;
        private int Minutes;
        private int Seconds;

        public void SetTime(int hours, int minutes)
        {
            if (hours < 0 || hours > 23)
            {
                Console.WriteLine("Invalid hours!");
                return;
            }
            if (minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Invalid minutes!");
                return;
            }

            Hours = hours;
            Minutes = minutes;
            Seconds = 0;
        }

        public void SetTime(int seconds)
        {
            if (seconds < 0)
            {
                Console.WriteLine("Can't accept negative value");
                return;
            }

            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;

            Hours %= 24;

        }
        public void DisplayTime()
        {
            Console.WriteLine($"Time: {Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }
    }
}
