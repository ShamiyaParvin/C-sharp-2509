using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part7
{
    public class Process
    {
        public event EventHandler OnCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started ...");
            Task.Delay(1000).Wait();
            Console.WriteLine("Process complete");

            if(OnCompleted != null)
            {
                OnCompleted(this, EventArgs.Empty);
            }
        }
    }
}
