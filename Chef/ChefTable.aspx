<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChefTable.aspx.cs" Inherits="ChefTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <style>
        html, body,table {
            height: 100%;
            width: 100%;
            padding: 0;
            margin: 0;
        }
        th{
            align-items:center;
            color:white;
        }
        td{
            text-align:center;
            align-content:center;
             color:white;
        }
       .auto-style3 {
           width: 232px;
       }
       .auto-style4 {
           width: 192px;
       }
       
    </style>
    <title></title>
</head>
<body background="Bg.jpg">
    <form id="form1" runat="server" >
        <asp:ScriptManager EnablePartialRendering="true"
 ID="ScriptManager1" runat="server"></asp:ScriptManager>
 <div>
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
 <ContentTemplate>
        <div>
            <table border="1" style="width: 100%" id="table1" runat="server" width="100%" >
                <tr>
                    <th>Name</th>
                    <th>Items</th>
                    <th >Ordered Time</th>            
                    <th>Status</th>
                    <th>Prepared Time</th>
                </tr>
            </table>
        </div>
     </ContentTemplate>
 </asp:UpdatePanel>
    </form>
</body>
</html>
