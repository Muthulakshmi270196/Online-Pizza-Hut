using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;
using System.Data;



public partial class DeliveryBoyTable : System.Web.UI.Page
{
    
    Button buttons;
    MySqlConnection con;
    MySqlCommand cmd,cmd2;
    MySqlDataAdapter da;
    DataSet ds = new DataSet();
    Int32[] row = new Int32[50];
    static string time;
    int key = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        
       

            con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
            con.Open();
        if (!IsPostBack)
        {
            cmd = new MySqlCommand("create table if not exists temp as Select * from deliveryboy where PreparedTime is not null and Status is null", con);
            
            cmd.ExecuteNonQuery();
            if ( key==cmd.ExecuteNonQuery())
            {
                cmd = new MySqlCommand("truncate table temp", con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("drop table temp", con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("create table temp as Select * from deliveryboy where PreparedTime is not null and Status is null", con);
                cmd.ExecuteNonQuery();
            }
               
            
           
                
            
            cmd2 = new MySqlCommand("select * from deliveryboy where PreparedTime is not null and Status is null", con);
        }
        else
        {
            cmd2 = new MySqlCommand("Select * from temp", con);
        }
            da = new MySqlDataAdapter(cmd2);
            da.Fill(ds);
            cmd2.ExecuteNonQuery();
        
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
                        table1.Rows[i + 1].Cells[0].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["CustomerName"]);
                        table1.Rows[i + 1].Cells[1].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["Address"]);
                        table1.Rows[i + 1].Cells[2].InnerText = Convert.ToString(ds.Tables[0].Rows[i]["PreparedTime"]);
                        buttons = new Button();
                        buttons.Text = "DELIVERED";
                        table1.Rows[i + 1].Cells[3].Controls.Add(buttons);
                        buttons.ID = (i + 1).ToString();
                        buttons.Click += new EventHandler(Button_Click);


                    }

                }
            }
        
        
        
        
        
    }

    private void Button_Click(object sender, EventArgs e)
    {
        
            con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
            con.Open();
            Button button = sender as Button;
            int temp = Convert.ToInt32(button.ID);
            button.BackColor = System.Drawing.Color.Green;
            button.ForeColor = System.Drawing.Color.White;
            button.Enabled = false;
            DateTime dt = DateTime.Now;
            time = dt.ToLongTimeString();
            cmd = new MySqlCommand("update deliveryboy set Status='Delivered' where CustomerName='" + table1.Rows[temp].Cells[0].InnerText + "' and Status is null;", con);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("update deliveryboy set DeliveredTime='" + time + "' where CustomerName='" + table1.Rows[temp].Cells[0].InnerText + "' and DeliveredTime is null;", con);
            cmd.ExecuteNonQuery();
            table1.Rows[temp].Cells[4].InnerText = time;
        
       
    }


   


}