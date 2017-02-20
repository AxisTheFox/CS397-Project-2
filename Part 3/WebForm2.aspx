<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Part_3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <p>Select Major:<br />
            <asp:DropDownList ID="ddlMajors" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMajors_SelectedIndexChanged">
            </asp:DropDownList>
        </p>

    </div>
    </form>
</body>
</html>
