<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDayDifference.aspx.cs" Inherits="WebApplicationCalenderControl.WebFormDayDifference" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Difference Between Two Calendar Dates</h2>
            <br />
            <br />
            <asp:Label Text="Select First Date" runat="server" />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Label Text="Select Second Date" runat="server" />
            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" Font-Bold="True" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
