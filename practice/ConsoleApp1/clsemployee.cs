using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class clsemployee
    {
        public clsemployee()
        {
            Console.WriteLine("constructor object created");
        }
        ~ clsemployee()

        {
            Console.WriteLine("object is destroyed");
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
