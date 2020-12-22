using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法
{
   public static class Class1
    {
        public static string ToPascal(this string s) {

            string[] array = s.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (i==0)
                {
                    array[i] = array[i].ToLower();
                }
                else
                {
                    array[i] = array[i].Substring(0,1).ToUpper() + array[i].Substring(1).ToLower();
                }

            }
            return string.Join("",array);
        }
    }
}
