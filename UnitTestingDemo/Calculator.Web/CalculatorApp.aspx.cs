using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.Web
{
    public partial class CalculatorApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            int result = Calculator.Library.Calculator.Divide(Convert.ToInt32(txtNumerator.Text), Convert.ToInt32(txtDenominator.Text));
            txtResult.Text = result.ToString();
        }
    }
}