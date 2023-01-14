<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 30%;
        }
        .style2
        {
            height: 24px;
            width: 372px;
        }
        .style3
        {
            width: 372px;
        }
        .style4
        {
            width: 372px;
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style3">
    <asp:ListBox ID="ListBox1" runat="server" Height="199px" Width="312px"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Linq - proste zapytanie" Width="314px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Linq - filtrowanie danych" Width="315px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Linq - tworzenie własnych zapytań (makro: new)" Width="311px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Linq - filtrowanie zapytań innymi zapytaniami" Width="313px" />
            </td>
        </tr>
        <tr>
            <td class="style4">
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="Linq - Join w zapytaniu" Width="312px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
    <div>
    
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
