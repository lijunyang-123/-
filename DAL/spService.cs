using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class spService
    {
        public static List<products> query(){
            //实例化EF对象
            Shopping_mallEntities s = new Shopping_mallEntities();
            //var obj = s.products.Select(p=>p);
            //return obj.ToList();
            return s.products.ToList();
        }

        public static int del(int id) 
        {
            Shopping_mallEntities s = new Shopping_mallEntities();
            var obj = s.products.Where(p => p.productid == id).Select(p=>p);
            s.products.Remove(obj.First());
            return s.SaveChanges();
        }

        public static int add(products p) 
        {
            Shopping_mallEntities s = new Shopping_mallEntities();
            s.products.Add(p);
            return s.SaveChanges();
        }
    }
}
