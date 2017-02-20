<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <p>Select Year:&nbsp&nbsp&nbsp
            <asp:DropDownList ID="ddlYear" runat="server" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>- Select Year -</asp:ListItem>
                <asp:ListItem>Freshman</asp:ListItem>
                <asp:ListItem>Sophomore</asp:ListItem>
                <asp:ListItem>Junior</asp:ListItem>
                <asp:ListItem>Senior</asp:ListItem>
            </asp:DropDownList></p>

    </div>
    </form>
</body>
</html>
