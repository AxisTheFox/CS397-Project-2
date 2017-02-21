using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsConnection"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand("select GPA, FirstName, LastName from Information as i inner join Academics as a on i.StudentIDNumber=a.StudentIDNumber where GPA>=@gpa", conn);
            cmd.Parameters.AddWithValue("@gpa", gpaSearchBox.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayGridView.DataSource = dt;
            displayGridView.DataBind();
        }
    }
}