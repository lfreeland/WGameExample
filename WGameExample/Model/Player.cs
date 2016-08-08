using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGameExample.Model
{
    public class Player
    {
        public int Age { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Alignment { get; set; }
        public String Mood { get; set; }

        public void displayInformationInConsole()
        {
            Console.WriteLine("*** " + FirstName + " " + LastName + " ***");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Alignment: " + Alignment);
            Console.WriteLine("Mood: " + Mood + Environment.NewLine);
        }
    }
}
