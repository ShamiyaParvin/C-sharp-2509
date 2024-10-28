using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Configuration
    {
        public static string ApplicationName { get; set; }
        public string UserPreference { get; set; }

        static Configuration()
        {
            ApplicationName = "My Application";
            Console.WriteLine("Static constructor : Application name set to: " + ApplicationName);
        }
        public Configuration(string userPreference)
        {
            UserPreference = userPreference;
            Console.WriteLine("Instance constructor : User preference set to");
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"User Preference: {UserPreference}");
        }
    }
}
