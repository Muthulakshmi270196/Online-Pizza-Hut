<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        html, body {
            height: 100%;
            width: 100%;
            padding: 0;
            margin: 0;
        }
        table{
            

        }
        th{
            text-align:center;
            font-family:'Times New Roman';
            color:brown;
        }
       td{
            font-family:'Times New Roman';
            text-align:center;
            color:white;
        }
         .auto-style7 {
             height: 570px;
             width: 976px;
             position: absolute;
             top: 0px;
             left: 0px;
             margin-left: 200px;
         }
         .auto-style11 {
             position: absolute;
             top: 411px;
             height: 28px;
             width: 62px;
             right: 581px;
         }
         .auto-style12 {
             position: absolute;
             top: 402px;
             left: 437px;
             z-index: 1;
             height: 34px;
             width: 135px;
         }
         .auto-style13 {
             position: absolute;
             top: 507px;
             left: 266px;
             z-index: 1;
             width: 165px;
             height: 48px;
         }
         .auto-style14 {
             position: absolute;
             top: 506px;
             left: 515px;
             z-index: 1;
             height: 46px;
             width: 172px;
         }
         .auto-style15 {
             height: 25px;
         }
         .auto-style16 {
             width: 70%;
             height: 195px;
             position: absolute;
             top: 0px;
             left: 146px;
         }
         .auto-style17 {
             height: 33px;
             position: absolute;
             top: 65px;
             left: 0px;
             width: 100%;
             z-index: 1;
         }
    </style>
</head>
<body background="images%20(2).jpg">
    <form id="form1" runat="server" class="auto-style7" style="z-index: 1">
        <div  style="text-align:center; margin: 0 auto; text-align:left; z-index: 1;" class="auto-style16">
        <table border="1" id="table1" runat="server" class="auto-style17" > 
            <tr>  
                <th class="auto-style15">Items</th>
                <th class="auto-style15">Size</th>
                <th class="auto-style15">Quantity</th>
                <th class="auto-style15">Unit Price</th>
                <th class="auto-style15">Amount</th>
            </tr>  
        </table> 
            </div>
        
    <asp:Label ID="Label7" runat="server" 
        Text="Total" 
        ForeColor="White" BorderStyle="None" CssClass="auto-style11" Font-Bold="True" Font-Size="X-Large"></asp:Label>
   
        
    
    
        
        
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Enabled="False"></asp:TextBox>
   
        
    
    
        
        
        <asp:Button ID="Button1" runat="server" BackColor="Red" BorderStyle="None" CssClass="auto-style13" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="White" OnClick="Button1_Click" Text="Go Back" />
        <asp:Button ID="Button2" runat="server" BackColor="#009900" BorderStyle="None" CssClass="auto-style14" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" ForeColor="White" OnClick="Button2_Click" Text="Confirm Order" />
   
        
    
    
        
        
    </form>
</body>
</html>
