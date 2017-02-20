using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int minimumCreditHours = 0;
        private int maximumCreditHours = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ddlYear.Items.FindByValue("- Select Year -").Enabled = false;
            }
        }

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetermineCreditHourRange();
            OleDbConnection conn = ConnectToDatabase();
            OleDbCommand cmd = CreateOleDbCommand("select * from Academics as a inner join Information as i on a.StudentIDNumber=i.StudentIDNumber where CreditHours >=@min and CreditHours <=@max", conn);
            cmd.Parameters.AddWithValue("@min", minimumCreditHours);
            cmd.Parameters.AddWithValue("@max", maximumCreditHours);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                OleDbCommand cmd2 = CreateOleDbCommand("select FirstName, LastName from Information where StudentIDNumber=@i", conn);
                cmd2.Parameters.AddWithValue("@i", rdr["a.StudentIDNumber"].ToString());
                OleDbDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    Response.Write(rdr["FirstName"].ToString() + " " + rdr["LastName"].ToString() + "<br />");
                }
                rdr2.Close();
            }
            rdr.Close();
            conn.Close();
        }

        private void DetermineCreditHourRange()
        {
            switch (ddlYear.SelectedValue)
            {
                case "Freshman":
                    minimumCreditHours = 0;
                    maximumCreditHours = 30;
                    break;
                case "Sophomore":
                    minimumCreditHours = 31;
                    maximumCreditHours = 60;
                    break;
                case "Junior":
                    minimumCreditHours = 61;
                    maximumCreditHours = 90;
                    break;
                case "Senior":
                    minimumCreditHours = 91;
                    maximumCreditHours = 120;
                    break;
            }
        }

        private OleDbConnection ConnectToDatabase()
        {
            return new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsConnection"].ToString());
        }

        private OleDbCommand CreateOleDbCommand(string qry, OleDbConnection conn)
        {
            return new OleDbCommand(qry, conn);
        }
    }
}