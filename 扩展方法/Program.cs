using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome to beijing";
           
            Console.WriteLine(name.ToPascal());
        }
    }
}
