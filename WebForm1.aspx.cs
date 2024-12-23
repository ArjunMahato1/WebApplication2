using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Num1, Num2, Sum;
            Num1 = int.Parse(TextBox1.Text);
            Num2 = int.Parse(TextBox2.Text);
            Sum = Num1 + Num2;
            Label3.Visible=true;
            Label3.Text = "Total is:" + Sum;

        }
    }
}