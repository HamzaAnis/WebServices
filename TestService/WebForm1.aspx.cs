using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestService.CalculatorService;

namespace TestService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorClient c=new CalculatorClient();
            Label1.Text = (c.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text))).ToString();
        }
    }
}