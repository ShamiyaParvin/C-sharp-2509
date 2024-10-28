using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignments
{
    public interface IPrintable
    {
        void Print(); 
    }
    public interface IScanable
    {
        void Scan();
    }

    public class PrinterScanner : IPrintable, IScanable
    {
        public void Print()
        {
            Console.WriteLine("printing something....");
        }
        public void Scan()
        {
            Console.WriteLine("scanning...");
        }
    }
}
