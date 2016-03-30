using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

public partial class CarLists : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string imp = Session["importer"].ToString();
        string description = Session["description"].ToString();
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            string strQuery = "SELECT brand, year, hp, importer, description FROM Cars WHERE importer='"+imp+"' ORDER BY year ASC";
            SqlCommand cmd = new SqlCommand(strQuery);
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}
