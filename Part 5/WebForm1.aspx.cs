using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsConnection"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Information WHERE Zip LIKE @z", conn);
            cmd.Parameters.AddWithValue("@z", tbxZipSearch.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();
        }
    }
}