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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                binding();
            }
        }

        private void binding()
        {
            this.GridView1.DataSource = spManager.query();
            this.GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="del")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                int count = spManager.del(id);
                if (count>0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "alert('删除成功')", true);
                    binding();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(),"","alert('删除失败')",true);
                    return;
                }
            }
        }
    }
}