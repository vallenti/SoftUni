using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim().Length < 3)
        {
            Label1.Text = "Описанието не може бъде по-кратко от 3 символа";
        }
        else
        {
            Session["importer"] = DropDownList1.SelectedValue;
            Session["description"] = TextBox1.Text;
            Response.Redirect("list.aspx");
        }
    }
}