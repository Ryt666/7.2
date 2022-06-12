using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _7._2_Dispose
{
    class Resource
    {
        public int b { get; set; }

        private bool disp = false;

        public Resource(int b)
        {
            this.b = b;
        }

        public void Disposing(Resource obj)
        {
            StreamWriter sw = new StreamWriter(@"D:\Учёба\2 курс\4 семестр\ООП\7.2\log.txt", true);
            if (!disp)
            {
                sw.WriteLine(DateTime.UtcNow.ToString());
                sw.WriteLine("Object {0} is removed.", obj.b);
                sw.WriteLine();
                obj = null;
                GC.SuppressFinalize(this);
                disp = true;
            }
            sw.Close();
        }


    }
}
