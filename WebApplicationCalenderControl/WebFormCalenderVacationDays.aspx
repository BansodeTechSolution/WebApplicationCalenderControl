<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalenderVacationDays.aspx.cs" Inherits="WebApplicationCalenderControl.WebFormCalenderVacationDays" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar Vacation Highliter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calendar Vacation Highliter </h2>
            <asp:Calendar ID="CalenderVacation" runat="server"
                OnDayRender="CalenderVacation_DayRender"></asp:Calendar>
        </div>
    </form>
</body>
</html>
