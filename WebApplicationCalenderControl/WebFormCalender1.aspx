<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalender1.aspx.cs" Inherits="WebApplicationCalenderControl.WebFormCalender1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calender control Display Message</h2>
            <asp:Calendar ID="Calendar1" runat="server" 
                OnSelectionChanged="Calendar1_SelectionChanged"
                OnDayRender="Calendar1_DayRender"></asp:Calendar>
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true" Font-Size="Larger" ForeColor="SteelBlue"></asp:Label>
        </div>
    </form>
</body>
</html>
