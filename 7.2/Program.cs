using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Resource> obj = new List<Resource>();
            obj.Add(new Resource(1));
            obj.Add(new Resource(2));
            obj.Add(new Resource(3));
            

            foreach (Resource o in obj)
            {
                o.Disposing(o);
            }

            Console.WriteLine("Deleting completed!");
            Console.ReadKey();
        }

    }
   
}

