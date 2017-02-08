using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setCarImage();
            lblResult.Text = "";
        }

        private void setCarImage()
        {
            switch (ddlVehicleType.SelectedItem.Text)
            {
                case "Economy":
                    imgSelectedCar.ImageUrl = "~/images/economy.png";
                    break;
                case "Compact":
                    imgSelectedCar.ImageUrl = "~/images/compact.png";
                    break;
                case "Intermediate":
                    imgSelectedCar.ImageUrl = "~/images/intermediate.png";
                    break;
                case "Standard":
                    imgSelectedCar.ImageUrl = "~/images/standard.png";
                    break;
                case "Full-Size":
                    imgSelectedCar.ImageUrl = "~/images/full-size.png";
                    break;
                default:
                    imgSelectedCar.Visible = false;
                    break;
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalCost = calculateTotalCost();
            if (totalCost > 0)
            {
                lblResult.Text = "Total cost: $" + totalCost;
            }
            else
            {
                lblResult.Text = "Invalid input";
            }
        }

        private double calculateTotalCost()
        {
            try
            {
                double dailyCharge = double.Parse(ddlVehicleType.SelectedValue);
                double numberOfDays = double.Parse(tbxNumberOfDays.Text);
                return dailyCharge * numberOfDays;
            }
            catch (Exception)
            {
                return -1.0;
            }
        }
    }
}