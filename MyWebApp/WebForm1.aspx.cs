using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MyWebApp
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string myQuery = TextBox1.Text;
            ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
            DataTable answer = serv.GetCustomer(myQuery);
            GridView1.DataSource = answer;

            GridView1.DataBind();
            //TextBox1.Text = answer;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}