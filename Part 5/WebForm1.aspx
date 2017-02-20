<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Search by area code:
                <br />
                <asp:TextBox ID="tbxZipSearch" runat="server" TextMode="Number"></asp:TextBox>
                &nbsp&nbsp&nbsp
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                <br />
                <br />
                <asp:GridView ID="gvDisplay" runat="server"></asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
