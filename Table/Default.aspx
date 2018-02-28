<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html, body,table {
            height: 100%;
            width: 100%;
            padding: 0;
            margin: 0;
        }
    </style>
    
&nbsp;</head><body><form id="form1" runat="server">
         <table style=" text-align: center;">  
            <tr>  
                <td align="center">  
                    <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>  
                </td>  
            </tr>  
        </table> 
    </form>
</body>
</html>
