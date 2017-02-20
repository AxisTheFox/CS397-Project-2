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
    public partial class WebForm2 : System.Web.UI.Page
    {
        ListItem selectMajorListItem = new ListItem("- Select Major -");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillMajorsDropDown();
            }
        }

        protected void ddlMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMajors.Items.Remove(selectMajorListItem);
            OleDbConnection conn = ConnectToDatabase();
            OleDbCommand cmd = CreateOleDbCommand("select * from Academics as a inner join Information as i on a.StudentIDNumber=i.StudentIDNumber where a.MajorCode=@m", conn);
            cmd.Parameters.AddWithValue("@m", ddlMajors.SelectedValue);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                OleDbCommand cmd2 = CreateOleDbCommand("select FirstName, LastName from Information where StudentIDNumber =@i", conn);
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

        private void FillMajorsDropDown()
        {
            ddlMajors.Items.Add(selectMajorListItem);
            OleDbConnection conn = ConnectToDatabase();
            OleDbCommand cmd = CreateOleDbCommand("select distinct MajorName, MajorCode from Majors", conn);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ddlMajors.Items.Add(new ListItem(rdr["MajorName"].ToString(), rdr["MajorCode"].ToString()));
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