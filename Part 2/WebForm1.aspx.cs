using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursParked = double.Parse(tbxHoursParked.Text);
                double totalCost = 5.00;
                if (hoursParked > 3.00)
                {
                    double remainingHours = hoursParked - 3.00;
                    while (remainingHours >= 1.00)
                    {
                        remainingHours -= 1.00;
                        totalCost += 1.50;
                    }
                    if (remainingHours > 0.00)
                    {
                        totalCost += 1.50;
                    }
                    if (totalCost > 18.00)
                    {
                        totalCost = 18.00;
                    }
                }
                lblResult.ControlStyle.ForeColor = System.Drawing.Color.Black;
                lblResult.Text = "Total Cost: $" + totalCost;
            }
            catch (Exception)
            {
                lblResult.ControlStyle.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "Invalid input.";
            }
        }
    }
}