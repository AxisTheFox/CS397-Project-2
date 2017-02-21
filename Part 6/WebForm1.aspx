<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <p>
            Search by GPA:
            <br />
            <asp:TextBox ID="gpaSearchBox" runat="server"></asp:TextBox>
            &nbsp&nbsp&nbsp
            <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
            <br />
            <br />
            <asp:GridView ID="displayGridView" runat="server"></asp:GridView>
        </p>

    </div>
    </form>
</body>
</html>
