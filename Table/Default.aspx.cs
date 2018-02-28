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

public partial class _Default : System.Web.UI.Page
{
    MySqlConnection con;
    MySqlCommand cmd;
    string str;
    MySqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        Button button2 = new Button();
        button2.Text="PREPARED";
        button2.Click += new EventHandler(Button2_Click);
      
        con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
        con.Open();
        cmd = new MySqlCommand("Select * from CustomerDetails", con);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();
        htmlTable.Append("<table border='1'width='100%'>");
        htmlTable.Append("<tr style='background-color:green; color: White;'><th>Name</th><th>Items</th><th>Ordered Time</th><th>Response</th><th>Accepted Time</th><th>Status</th><th>Prepared Time</th></tr>");

        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    htmlTable.Append("<tr style='color: White;'>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Name"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Phone_No"] + "</td>");
                    htmlTable.Append("<td></td>");
                    htmlTable.Append("<td align='center'><input id='Button1' runat='server'  class='button right' onServerClick='Button1_Click' type='submit' value='ACCEPT' /> </td>");          
                    htmlTable.Append("<td></td>");
                    htmlTable.Append("<td align='center'><input id='Button2' runat='server'  class='button right' onServerClick='Button2_Click' type='submit' value='PREPARED' /></td>");

                    htmlTable.Append("<td></td>");
                   
                    htmlTable.Append("</tr>");
                }
                htmlTable.Append("</table>");
                
                DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
            else
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");
                htmlTable.Append("</tr>");
            }
        }
    }
    protected void Button1_Click(object sender,EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}