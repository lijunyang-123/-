//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public Nullable<int> typeid_1 { get; set; }
        public Nullable<int> typeid_2 { get; set; }
        public string recommended { get; set; }
        public string specials { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> userprice { get; set; }
        public Nullable<decimal> specialsprice { get; set; }
        public Nullable<int> pointcount { get; set; }
        public string imagepath { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<int> sellcount { get; set; }
        public string description { get; set; }
    }
}