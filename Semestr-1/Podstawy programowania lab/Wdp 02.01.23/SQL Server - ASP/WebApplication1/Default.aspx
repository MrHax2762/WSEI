<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:aspnetConnectionString4 %>" 
        SelectCommand="SELECT * FROM [aspnet]" 
        
        
>
        </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" EnableModelValidation="True" DataKeyNames="id">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="i1" HeaderText="i1" SortExpression="i1" />
            <asp:BoundField DataField="p1" HeaderText="p1" SortExpression="p1" />
            <asp:BoundField DataField="p2" HeaderText="p2" SortExpression="p2" />
        </Columns>
    </asp:GridView>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="Błędna wartość" MaximumValue="10000" 
        MinimumValue="0" Type="Integer"></asp:RangeValidator>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator2" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="Błędna wartość" MaximumValue="10000" 
        MinimumValue="0" Type="Integer"></asp:RangeValidator>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Wstaw do tabeli" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Pobierz" />
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>

    <br />

    </form>
</body>
</html>
