using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;

namespace Part_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillStatesDropDown();
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = ConnectToDatabase();
            OleDbCommand cmd = CreateOleDbCommand("select FirstName, LastName from Information where State=@s", conn);
            cmd.Parameters.AddWithValue("@s", ddlStates.SelectedValue);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Response.Write(rdr["FirstName"].ToString() + " " + rdr["LastName"].ToString() + "<br/>");
            }
            rdr.Close();
            conn.Close();
        }

        private void FillStatesDropDown()
        {
            OleDbConnection conn = ConnectToDatabase();
            OleDbCommand cmd = CreateOleDbCommand("select distinct State from Information", conn);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ddlStates.Items.Add(new ListItem(rdr["State"].ToString()));
            }
            rdr.Close();
            conn.Close();
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