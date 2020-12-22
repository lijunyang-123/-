using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;
namespace LINQDemo1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            products p = new products();
            p.productname = this.TextBox1.Text;
            p.price =Convert.ToInt32(this.TextBox2.Text);
            p.typeid_1 = Convert.ToInt32(this.TextBox3.Text);
            p.typeid_2 = Convert.ToInt32(this.TextBox4.Text);
            if (spManager.add(p)>0)
            {
                ClientScript.RegisterStartupScript(this.GetType(),"", "alert('添加成功');location.href='WebForm1.aspx';", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('添加失败');", true);
            }
        }
    }
}