<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalender3.aspx.cs" Inherits="WebApplicationCalenderControl.WebFormCalender3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selected Day Styling</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="margin: 20px">
            <h2>Calendar Selected Day Styling</h2>
            <asp:Calendar ID="Calendar1" runat="server"
                OnSelectionChanged="Calendar1_SelectionChanged"
                BackColor="#f0f0f0" BorderColor="Black" BorderWidth="1px">

                <%--  Style for the selected day --%>
                <SelectedDayStyle BackColor="#FFCC00" ForeColor="Red" Font-Bold="True" />

                <%-- style for todays date --%>
                <TodayDayStyle BackColor="#99FF99" ForeColor="Black" Font-Bold="True" />

                <%-- Weekend Styling --%>
                <WeekendDayStyle BackColor="#F2F2F2" ForeColor="Red" />
            </asp:Calendar>
            <br />
            <asp:Label ID="lblSelectedDate" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
