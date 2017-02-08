<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent today!</title>
    <link rel="stylesheet" type="text/css" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">

        <h1>Vehicle Types and Pricing</h1>

        <p>
        <asp:Image ID="imgSelectedCar" runat="server" />
        </p>

        <p>Vehicle Type:&nbsp&nbsp&nbsp
        <asp:DropDownList ID="ddlVehicleType" runat="server" AutoPostBack="True">
            <asp:ListItem Value="24.99">Economy</asp:ListItem>
            <asp:ListItem Value="29.99">Compact</asp:ListItem>
            <asp:ListItem Value="34.99">Intermediate</asp:ListItem>
            <asp:ListItem Value="44.99">Standard</asp:ListItem>
            <asp:ListItem Value="49.99">Full-Size</asp:ListItem>
        </asp:DropDownList>
        </p>

        <p>Number of Days:&nbsp&nbsp&nbsp
            <asp:TextBox ID="tbxNumberOfDays" runat="server" TextMode="Number"></asp:TextBox>
        </p>

        <p>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
        </p>

        <p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </p>

    <div>
    
    </div>
    </form>
</body>
</html>
