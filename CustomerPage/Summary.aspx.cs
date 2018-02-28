using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

public partial class Summary : System.Web.UI.Page
{
    MySqlConnection con;
    MySqlCommand cmd;
    MySqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();
    int total=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
        con.Open();
        cmd = new MySqlCommand("Select * from Items", con);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();
       
        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    HtmlTableRow row = new HtmlTableRow();
                    table1.Rows.Add(row);
                    for (int j = 0; j < 5; j++)
                    {
                        HtmlTableCell cell = new HtmlTableCell();
                        row.Cells.Add(cell);
                    }
                    table1.Rows[i + 1].Cells[0].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
                    table1.Rows[i + 1].Cells[1].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["size"]);
                    table1.Rows[i + 1].Cells[2].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["count"]);
                    table1.Rows[i + 1].Cells[3].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["unit_price"]);
                    table1.Rows[i + 1].Cells[4].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["Amount"]);
                    total = total + Convert.ToInt32(table1.Rows[i + 1].Cells[4].InnerText);
                }
                
            }
            
        }
        TextBox1.Text = total.ToString();
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("First.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Second.aspx");
    }
}