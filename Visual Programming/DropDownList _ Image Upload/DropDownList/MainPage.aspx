<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="DropDownList.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:employee_crudConnectionString %>" SelectCommand="SELECT [id], [fname] +' '+ [lname] as Name FROM [employees]"></asp:SqlDataSource>
            <br />
            <asp:DropDownList runat="server" ID="ddl1" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="id" ></asp:DropDownList>
            <asp:DropDownList runat="server" ID="ddl" ></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
        </div>
        <asp:FileUpload ID="fup" runat="server" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload" />
    </form>
</body>
</html>

