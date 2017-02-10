<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parking Calculator</title>
    <link rel="stylesheet" type="text/css" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Parking Cost Calculator</h1>

        <p>Total Hours Parked:&nbsp&nbsp&nbsp
            <asp:TextBox ID="tbxHoursParked" runat="server"></asp:TextBox>
        </p>

        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />

        <h3>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </h3>
    
    </div>
    </form>
</body>
</html>
