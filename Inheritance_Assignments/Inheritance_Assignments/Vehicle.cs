using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public interface IMovable
    {
        void Move();
    }
    public interface IRechargable
    {
        void Recharge();
    }
    public class Vehicle : IMovable
    {
        public virtual void Move() 
        {
            Console.WriteLine("Vehicle is moving...");
        }
    }
    public class ElectricCar : Vehicle, IRechargable
    {
        public override void Move()
        {
            Console.WriteLine("Electric vehicle is moving...");
        }

        public void Recharge()
        {
            Console.WriteLine("Electric car is rechargable");
        }
    }
}
