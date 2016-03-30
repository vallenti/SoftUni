using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AddCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckIfEmptyData())
        {
            Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#CC0000");
            Label1.Text = "Моля попълнете всички полета";
        }
        else if(!ContainsImporter())
        {
            InsertImporterRecord();
            InsertCarRecord(); 
        }
        else
        {
            InsertCarRecord();
        }
    }
    private void ClearForm()
    {
        tb_brand.Text = "";
        tb_year.Text = "";
        tb_hp.Text = "";
        tb_importer.Text = "";
        tb_decrtiption.Text = "";
        Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#006600");
        Label1.Text = "Успешно добавихте нов автомобил в базата!";
    }
    private bool CheckIfEmptyData()
    {
        bool isEmpty = false;
        if (tb_brand.Text == "" || tb_year.Text == "" || tb_hp.Text == "" || tb_importer.Text == "" || tb_decrtiption.Text == "")
        {
            isEmpty = true;
        }
        return isEmpty;
    }
    private bool ContainsImporter()
    {
        bool isContained = false;
         string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                string strQuery = String.Format("SELECT count(*) FROM Importers WHERE importer='{0}'", tb_importer.Text);
                SqlCommand cmd = new SqlCommand(strQuery);
                cmd.Connection = con;
                con.Open();
                Int32 count = (Int32) cmd.ExecuteScalar();
                if(count != 0){
                    isContained = true;
                }
            }
            return isContained;
    }
    private void InsertCarRecord()
    {
        string brand = tb_brand.Text;
        string year = tb_year.Text;
        string hp = tb_hp.Text;
        string importer = tb_importer.Text;
        string description = tb_decrtiption.Text;
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            string strQuery = String.Format("INSERT INTO [Cars](brand,year,hp,importer,description) VALUES('{0}',{1},{2},'{3}','{4}')", brand, year, hp, importer, description);
            SqlCommand cmd = new SqlCommand(strQuery);
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;
                con.Open();
                sda.InsertCommand = cmd;
                sda.InsertCommand.ExecuteNonQuery();
                ClearForm();
            }
        }
    }
    private void InsertImporterRecord()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            Label1.Text = tb_importer.Text;
            
            string strQuery = String.Format("INSERT INTO [Importers](importer) VALUES('{0}')",tb_importer.Text);
            SqlCommand cmd = new SqlCommand(strQuery);
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;
                con.Open();
                sda.InsertCommand = cmd;
                sda.InsertCommand.ExecuteNonQuery();
            }
        }
    }
}