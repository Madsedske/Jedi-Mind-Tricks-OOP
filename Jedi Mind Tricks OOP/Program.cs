using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_Tricks_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Mads", 23);
            people.Add("Andreas", 35);
            people.Add("Lars", 64);
            people["Hans"] = 24;

            people.Remove("Hans");

            foreach (KeyValuePair<string, int> items in people)
            {
                Console.WriteLine("{0} {1}", items.Key, items.Value);
            }


            Console.ReadKey();
        }
    }
}
