using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignments
{
    public interface IMovable
    {
        void Move(int distance);
    }
    public interface IDrawable
    {
        void Draw();
    }
    public class Car4 : IMovable, IDrawable
    {
        private string CarName;
        public Car4(string carName)
        {
            CarName = carName;
        }

        public void Move(int distance)
        {
            Console.WriteLine($"{CarName} has moved {distance} meters.");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a car named {CarName}.");
        }
    }
}
