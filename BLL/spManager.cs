using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class spManager
    {
        public static List<products> query()
        {
            return spService.query();
        }

        public static int del(int id)
        {
            return spService.del(id);
        }

        public static int add(products p)
        {
            return spService.add(p);
        }
        }
}
