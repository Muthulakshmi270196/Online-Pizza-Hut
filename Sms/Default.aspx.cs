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

    Button[] buttons = new Button[50];
    
    MySqlConnection con;
    MySqlCommand cmd;
    MySqlDataAdapter da;
    DataSet ds = new DataSet();
    Int32[] row = new Int32[50];
    static string time;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
        
        con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
        con.Open();
        cmd = new MySqlCommand("Select * from chef", con);
        da = new MySqlDataAdapter(cmd);
        da.Fill(ds);
        cmd.ExecuteNonQuery();
       
        

        
        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0,k=1; i < ds.Tables[0].Rows.Count&& k<=10; i++)
                {
                    HtmlTableRow row = new HtmlTableRow();
                    
                    table1.Rows.Add(row);
                    for(int j=0; j<5; j++)
                    {
                        HtmlTableCell cell = new HtmlTableCell();
                        row.Cells.Add(cell);
                    }   
                    table1.Rows[i+1].Cells[0].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                    table1.Rows[i+1].Cells[1].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["Items"]);
                    table1.Rows[i+1].Cells[2].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["OrderedTime"]);
                    buttons[k] = new Button();
                    buttons[k].Text = "PREPARED ";
                    table1.Rows[i+1].Cells[3].Controls.Add(buttons[k]);
                    buttons[k].Click+= delegate (send, EventArgs) => { Button_Click(sender, EventArgs, table1.Rows[i + 1].Cells[0].InnerText); };

                    table1.Rows[i + 1].Cells[4].InnerText = time;
                }

            }

        }
        con.Close();

    }

    private EventHandler Button_Click(object sender, string innerText)
    {
        Button button = sender as Button;
        button.BackColor = System.Drawing.Color.Green;
        button.ForeColor = System.Drawing.Color.White;
        button.Enabled = false;
        DateTime dt = DateTime.Now;
        time = dt.ToLongTimeString();
        cmd = new MySqlCommand("update chef set Status='Prepared' where CustomerName='" + innerText + "';", con);
        cmd.ExecuteNonQuery();
        cmd = new MySqlCommand("update chef set PreparedTime='" + time + "' where CustomerName='" +innerText+ "';", con);
        cmd.ExecuteNonQuery();
        throw new NotImplementedException();
    }

    private void Button_Click(object sender, EventArgs eventArgs, string innerText)
    {
        Button button = sender as Button;
        button.BackColor = System.Drawing.Color.Green;
        button.ForeColor = System.Drawing.Color.White;
        button.Enabled = false;
        DateTime dt = DateTime.Now;
        time = dt.ToLongTimeString();
        cmd = new MySqlCommand("update chef set Status='Prepared' where CustomerName='" + innerText + "';", con);
        cmd.ExecuteNonQuery();
        cmd = new MySqlCommand("update chef set PreparedTime='" + time + "' where CustomerName='" + innerText + "';", con);
        cmd.ExecuteNonQuery();
        throw new NotImplementedException();
       
    }

    private void Button_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        button.BackColor = System.Drawing.Color.Green;
        button.ForeColor = System.Drawing.Color.White;
        button.Enabled = false;
        
        //throw new NotImplementedException();

    }

    private void Button3_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        
        throw new NotImplementedException();
    }
}