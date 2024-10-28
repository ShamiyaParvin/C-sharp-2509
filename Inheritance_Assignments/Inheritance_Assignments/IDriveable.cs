using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public interface IDriveable
    {
        void Drive();
    }
    public interface IRaceable : IDriveable
    {
        void Race();
    }
    //implementing the IReadable in a class
    public class RaceableCar : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
        public void Race()
        {
            Console.WriteLine("Car is racing..");
        }
    }
}
