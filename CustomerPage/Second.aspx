<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Second.aspx.cs" Inherits="Secong" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 737px;
            top: 71px;
            left: 106px;
            position: absolute;
            width: 956px;
        }
        .auto-style1 {
            left: 106px;
            top: 70px;
            width: 848px;
            height: 767px;
            margin-left: 160px;
        }
        .auto-style2 {
            position: absolute;
            top: 39px;
            left: 272px;
            width: 329px;
            height: 39px;
        }
        .auto-style3 {
            z-index: 1;
            left: 338px;
            top: 487px;
            position: absolute;
            height: 37px;
            width: 225px;
        }
        .auto-style4 {
            bottom: 384px;
        }
    </style>
</head>
<body background="images%20(2).jpg">
    <form id="form1" runat="server" class="auto-style1">
    <asp:Label ID="Label8" runat="server" 
        Text="Address" 
        
        
        
        
        style="position:absolute; top: 394px; left: 197px; height: 29px; width: 81px; right: 639px;" 
        ForeColor="White"></asp:Label>
    <asp:Label ID="Label7" runat="server" 
        Text="Name" 
        
        
        
        
        style="position:absolute; top: 149px; height: 28px; width: 62px; right: 698px;" 
        ForeColor="White" BorderStyle="None"></asp:Label>
    <div style="margin-left: 640px">
        <asp:TextBox ID="TextBox1" runat="server" 
        
            style="top: 137px; left: 340px; position: absolute; height: 37px; width: 225px" Font-Names="Times New Roman" Font-Size="Medium" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
    <asp:TextBox ID="TextBox2" runat="server" 
        style="z-index: 1; left: 339px; top: 223px; position: absolute; height: 37px; width: 225px" Font-Names="Times New Roman" Font-Size="Medium" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Label ID="Label9" runat="server" 
        Text="Phone no" 
        
        
        
        
        style="position:absolute; top: 227px; left: 199px; height: 31px; width: 73px; right: 645px;" 
        ForeColor="White"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" 
        
        style="z-index: 1; left: 338px; top: 310px; position: absolute; height: 37px; width: 225px" CssClass="auto-style4" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server" 
        
        style="z-index: 1; left: 339px; top: 393px; position: absolute; height: 37px; width: 225px; bottom: 50px;" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" 
        
        
        style="z-index: 1; left: 339px; top: 439px; position: absolute; height: 37px; width: 225px" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" 
        
        style="z-index: 1; left: 339px; top: 533px; position: absolute; height: 37px; width: 225px" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox>
    <asp:Label ID="Label10" runat="server" 
        Text="Email ID" 
        
        
        
        
        style="position:absolute; top: 314px; left: 198px; height: 26px; width: 88px; right: 631px; bottom: 146px;" 
        ForeColor="White"></asp:Label>
    <asp:Button ID="Button1" runat="server" BackColor="#009900" BorderStyle="None" 
        Font-Bold="True" Font-Size="X-Large" ForeColor="White" 
        style="z-index: 1; left: 509px; top: 624px; position: absolute; height: 53px; width: 224px; right: 184px" 
        Text="Make Payment" OnClick="Button1_Click" />
    <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style3" Font-Names="Times New Roman" Font-Size="Medium"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" BackColor="Red" Font-Bold="True" 
        Font-Size="X-Large" ForeColor="White" 
        style="z-index: 1; left: 198px; top: 624px; position: absolute; height: 53px; width: 224px; right: 483px" 
        Text="Back" BorderStyle="None" onclick="Button2_Click" />
    <p>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label17" runat="server" Text="CUSTOMER DETAILS" 
        Font-Bold="True" Font-Italic="True" Font-Names="Times New Roman" 
        Font-Size="XX-Large" ForeColor="#CC3300" CssClass="auto-style2"></asp:Label>
    </p>
    </form>
    </body>
</html>
