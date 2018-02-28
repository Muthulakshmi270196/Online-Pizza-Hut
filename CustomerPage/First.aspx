<%@ Page Language="C#" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1 {
            height: 1292px;
            width: 985px;
            
            left: 164px;
            position: absolute;
            margin-left: 11px;
            margin-right: 0px;
        }
        .auto-style1 {
            top: 433px;
            left: 93px;
            position: absolute;
            height: 22px;
            width: 34px;
        }
    </style>
</head>
<body background="images%20(2).jpg">
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Veg Pizza.jpg" 
            style="top: 148px; left: 414px; position: absolute; width: 197px; height: 173px" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Paneer pizza.jpg" 
            
            style="top: 147px; left: 90px; position: absolute; width: 197px; height: 176px" />
    
        <asp:Button ID="Button8" runat="server" 
            style="top: 495px; left: 480px; position: absolute; height: 26px; width: 78px; right: 427px;" 
            Text="ADD" onclick="Button8_Click" BackColor="#333333" BorderStyle="None" 
            ForeColor="White" />
    
        <asp:Button ID="Button18" runat="server" 
            style="top: 521px; left: 873px; position: absolute; float: right; height: 26px; width: 78px; bottom: 745px;" 
            Text="REMOVE" onclick="Button18_Click" BackColor="#333333" 
            BorderStyle="None" ForeColor="White" />
    
    </div>
    <asp:Image ID="Image3" runat="server" ImageUrl="~/Chicken pizza.jpg" 
        style="top: 145px; left: 727px; position: absolute; width: 200px; height: 175px; right: -33px" />
    <asp:Image ID="Image4" runat="server" ImageUrl="~/sausage pizza.jpg" 
        style="top: 610px; left: 103px; position: absolute; width: 192px; height: 176px" />
    <asp:Image ID="Image5" runat="server" ImageUrl="~/DoubleCheese.jpg" 
        style="top: 610px; left: 420px; position: absolute; width: 192px; height: 176px" />
    <asp:Image ID="Image6" runat="server" ImageUrl="~/Mexican.jpg" 
        
        style="top: 610px; left: 740px; position: absolute; width: 193px; height: 175px" />
    <asp:Label ID="Label3" runat="server" Text="Chicken Pizza" 
        
        style="position:absolute; top: 342px; left: 787px; height: 26px; width: 93px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Veg Pizza" 
        
        style="position:absolute; top: 340px; left: 473px; height: 26px; width: 80px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Panneer Pizza" 
        
        
        style="position:absolute; top: 343px; left: 136px; height: 26px; width: 107px; right: 742px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="Sausage Pizza" 
        
        style="position:absolute; top: 811px; left: 140px; height: 26px; width: 104px; right: 650px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="Double Cheese Pizza" 
        
        style="position:absolute; top: 811px; left: 449px; height: 21px; width: 140px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label6" runat="server" Text="Mexican Green Wave" 
        
        style="position:absolute; top: 807px; left: 765px; height: 26px; width: 146px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label10" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        style="position:absolute; top: 844px; left: 112px; height: 37px; width: 191px;" 
        ForeColor="White"></asp:Label>
    <div style="margin-left: 40px">
        <asp:Label ID="Label8" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        style="position:absolute; top: 372px; left: 439px; height: 37px; width: 192px;" 
        ForeColor="White"></asp:Label>
    <asp:Label ID="Label11" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        style="position:absolute; top: 842px; left: 440px; height: 37px; width: 196px;" 
        ForeColor="White"></asp:Label>
    <asp:Label ID="Label12" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        style="position:absolute; top: 840px; left: 761px; height: 37px; width: 198px;" 
        ForeColor="White"></asp:Label>
    </div>
    <asp:Label ID="Label7" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        
        style="position:absolute; top: 376px; left: 104px; height: 37px; width: 193px; right: 688px;" 
        ForeColor="White"></asp:Label>
    <asp:Label ID="Label23" runat="server" Text="L: ₹300" 
        
        
        
        
        style="position:absolute; top: 467px; left: 884px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label20" runat="server" Text="L: ₹300" 
        
        
        
        
        style="position:absolute; top: 466px; left: 567px; width: 61px; height: 21px; right: 357px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label32" runat="server" Text="L: ₹300" 
        
        
        
        
        style="position:absolute; top: 923px; left: 888px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label29" runat="server" Text="L: ₹300" 
        
        
        
        
        style="position:absolute; top: 924px; left: 569px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label26" runat="server" Text="L: ₹300" 
        
        
        
        style="position:absolute; top: 926px; left: 252px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label15" runat="server" Text="L: ₹300" 
        
        
        
        
        style="position:absolute; top: 469px; left: 238px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label22" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 468px; left: 802px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label19" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 468px; left: 487px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label31" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 925px; left: 811px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label28" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 923px; left: 489px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label25" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 928px; left: 170px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label14" runat="server" Text="M: ₹200" 
        
        
        
        style="position:absolute; top: 469px; left: 159px; width: 61px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label21" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 469px; left: 723px; width: 58px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label18" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 468px; left: 410px; width: 58px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label30" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 927px; left: 729px; width: 58px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label27" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 922px; left: 412px; width: 58px; height: 21px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label24" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 929px; left: 91px; width: 58px; height: 21px; right: 836px;" 
        ForeColor="Red"></asp:Label>
    <asp:Label ID="Label13" runat="server" Text="S: ₹100" 
        
        
        
        style="position:absolute; top: 470px; left: 82px; width: 58px; height: 34px;" 
        ForeColor="Red"></asp:Label>
    <asp:Button ID="Button3" runat="server" 
        style="top: 509px; left: 231px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button3_Click" 
        BorderStyle="None" ForeColor="White" BackColor="#333333" />
    <asp:Button ID="Button2" runat="server" 
        style="top: 509px; left: 151px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button2_Click" 
        BorderStyle="None" ForeColor="White" BackColor="#333333" />
    <asp:Button ID="Button6" runat="server" 
        style="top: 541px; left: 232px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button6_Click1" BorderStyle="None" 
        ForeColor="White" BackColor="#333333" />
    <asp:Button ID="Button5" runat="server" 
        style="top: 542px; left: 151px; position: absolute; height: 26px; width: 78px; " 
        Text="REMOVE" onclick="Button5_Click" BorderStyle="None" 
        ForeColor="White" BackColor="#333333" />
    <asp:Button ID="Button1" runat="server" 
        style="top: 509px; left: 71px; position: absolute; height: 26px; width: 78px; right: 836px;" 
        Text="ADD" onclick="Button1_Click" 
        BorderStyle="None" ForeColor="White" BackColor="#333333" />
    <asp:TextBox ID="TextBox3" runat="server" 
        
        style="top: 433px; left: 247px; position: absolute; height: 22px; width: 34px" 
        Enabled="False" ontextchanged="TextBox3_TextChanged" BackColor="#333333" 
        BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" 
        
        style="top: 433px; left: 171px; position: absolute; height: 22px; width: 34px" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox10" runat="server" 
        
        
        
        style="top: 432px; left: 885px; position: absolute; height: 22px; width: 34px; right: 66px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server" 
        
        
        
        style="top: 433px; left: 735px; position: absolute; height: 22px; width: 34px; " 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox19" runat="server" 
        
        
        
        
        style="top: 890px; left: 898px; position: absolute; height: 22px; width: 31px; right: 56px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox18" runat="server" 
        
        
        
        
        style="top: 891px; left: 820px; position: absolute; height: 22px; width: 34px; right: 131px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox16" runat="server" 
        
        
        
        
        style="top: 892px; left: 577px; position: absolute; height: 22px; width: 34px; right: 374px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox15" runat="server" 
        
        
        
        
        style="top: 893px; left: 501px; position: absolute; height: 22px; width: 34px; right: 450px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox13" runat="server" 
        
        
        
        
        style="top: 896px; left: 261px; position: absolute; height: 22px; width: 34px; right: 690px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox12" runat="server" 
        
        
        
        
        style="top: 896px; left: 181px; position: absolute; height: 22px; width: 34px; right: 770px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox11" runat="server" 
        
        
        
        
        style="top: 896px; left: 98px; position: absolute; height: 22px; width: 34px; " 
        Enabled="False" ontextchanged="TextBox11_TextChanged" BackColor="#333333" 
        BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox1" runat="server" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White" CssClass="auto-style1">0</asp:TextBox>
    <asp:Label ID="Label17" runat="server" Text="WELCOME TO THE ONLINE PIZZA HUT" 
        style="position:absolute; top: 39px; left: 205px; width: 598px; height: 52px;" 
        Font-Bold="True" Font-Italic="True" Font-Names="Times New Roman" 
        Font-Size="XX-Large" ForeColor="#CC3300"></asp:Label>
    <asp:Button ID="Button17" runat="server" 
        style="top: 493px; left: 874px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button17_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button4" runat="server" 
        style="top: 545px; left: 72px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button4_Click" BorderStyle="None" 
        ForeColor="White" BackColor="#333333" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox4" runat="server" Font-Names="Times New Roman" 
        Font-Size="X-Large" 
        
        
        
        
        style="top: 1083px; left: 485px; position: absolute; height: 44px; width: 101px" 
        BackColor="#333333" BorderStyle="None" ForeColor="White" Enabled="False" OnTextChanged="TextBox4_TextChanged">0</asp:TextBox>
    <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
        style="top: 495px; left: 400px; position: absolute; height: 26px; width: 78px; right: 507px;" 
        Text="ADD" BorderStyle="None" 
        ForeColor="White" BackColor="#333333" />
    <asp:Button ID="Button9" runat="server" 
        style="top: 495px; left: 559px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button9_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button10" runat="server" 
        style="top: 526px; left: 400px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button10_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button11" runat="server" 
        style="top: 526px; left: 480px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button11_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button12" runat="server" 
        style="top: 526px; left: 560px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button12_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button13" runat="server" 
        style="top: 494px; left: 715px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button13_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button14" runat="server" 
        style="top: 522px; left: 715px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button14_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button15" runat="server" 
        style="top: 493px; left: 795px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button15_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button16" runat="server" 
        style="top: 522px; left: 794px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button16_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
         
    <asp:Button ID="Button19" runat="server" 
        style="top: 956px; left: 80px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button19_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
        

    <asp:Button ID="Button20" runat="server" 
        style="top: 986px; left: 80px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button20_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button21" runat="server" 
        style="top: 956px; left: 160px; position: absolute; height: 26px; width: 78px; right: 747px;" 
        Text="ADD" onclick="Button21_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button22" runat="server" 
        style="top: 985px; left: 160px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button22_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button23" runat="server" 
        style="top: 956px; left: 240px; position: absolute; height: 26px; width: 78px; right: 667px;" 
        Text="ADD" onclick="Button23_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button24" runat="server" 
        style="top: 985px; left: 240px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button24_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button26" runat="server" 
        style="top: 982px; left: 402px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button26_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button29" runat="server" 
        style="top: 955px; left: 562px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button29_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button30" runat="server" 
        style="top: 982px; left: 562px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button30_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button31" runat="server" 
        style="top: 953px; left: 720px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button31_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button32" runat="server" 
        style="top: 982px; left: 721px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button32_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button33" runat="server" 
        style="top: 954px; left: 800px; position: absolute; height: 26px; width: 78px; " 
        Text="ADD" onclick="Button33_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button34" runat="server" 
        style="top: 982px; left: 801px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button34_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:Button ID="Button35" runat="server" 
        style="top: 953px; left: 880px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button35_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button36" runat="server" 
        style="top: 982px; left: 882px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button36_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:TextBox ID="TextBox5" runat="server" 
        ontextchanged="TextBox20_TextChanged" 
        
        
        style="top: 432px; left: 425px; position: absolute; height: 22px; width: 34px" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" 
        
        style="top: 432px; left: 577px; position: absolute; height: 22px; width: 34px" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:TextBox ID="TextBox6" runat="server" 
        
        
        
        style="top: 432px; position: absolute; width: 34px; right: 454px; height: 22px;" 
        Enabled="False" ontextchanged="TextBox6_TextChanged" BackColor="#333333" 
        BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:Label ID="Label9" runat="server" 
        Text="Wheat | Olive oil | Garlic | Ginger | Cheese | Tomato" 
        
        
        
        style="position:absolute; top: 372px; left: 752px; height: 38px; width: 195px;" 
        ForeColor="White"></asp:Label>
    <asp:TextBox ID="TextBox14" runat="server" 
        
        
        
        
        style="top: 892px; left: 424px; position: absolute; height: 22px; width: 34px; right: 527px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:Button ID="Button25" runat="server" 
        style="top: 954px; left: 402px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button25_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button27" runat="server" 
        style="top: 954px; left: 482px; position: absolute; height: 26px; width: 78px" 
        Text="ADD" onclick="Button27_Click" BackColor="#333333" BorderStyle="None" 
        ForeColor="White" />
    <asp:Button ID="Button28" runat="server" 
        style="top: 982px; left: 482px; position: absolute; height: 26px; width: 78px" 
        Text="REMOVE" onclick="Button28_Click" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" />
    <asp:TextBox ID="TextBox17" runat="server" 
        
        
        
        
        style="top: 893px; left: 755px; position: absolute; height: 22px; width: 34px; right: 196px; margin-top: 0px;" 
        Enabled="False" BackColor="#333333" BorderStyle="None" ForeColor="White">0</asp:TextBox>
    <asp:Label ID="Label16" runat="server" Text="Total" 
        style="position:absolute; top: 1083px; left: 394px; width: 77px; height: 36px; right: 514px;" 
        Font-Bold="True" Font-Names="Times New Roman" Font-Size="XX-Large" 
        ForeColor="Red"></asp:Label>
    <asp:Button ID="Button37" runat="server" BackColor="#009900" BorderStyle="None" 
        Font-Bold="True" Font-Size="X-Large" ForeColor="White" 
        style="top: 1193px; left: 416px; position: absolute; height: 46px; width: 197px" 
        Text="Place Order" onclick="Button37_Click" />
    <asp:TextBox ID="TextBox20" runat="server" BackColor="#333333" 
        BorderStyle="None" ForeColor="White" 
        style="z-index: 1; left: 819px; top: 435px; position: absolute; height: 22px; width: 34px">0</asp:TextBox>
    </form>
</body>
</html>
