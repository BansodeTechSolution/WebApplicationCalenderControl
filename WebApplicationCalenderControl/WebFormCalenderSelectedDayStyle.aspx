<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalenderSelectedDayStyle.aspx.cs" Inherits="WebApplicationCalenderControl.WebFormCalenderSelectedDayStyle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calender1" runat="server"
                OnSelectionChanged="Calender1_SelectionChanged"
                SelectionMode="Day"
                BorderColor="Black"
                BorderWidth="2px"
                >
                <%-- Selected Day Styling --%>
                <SelectedDayStyle BackColor="#FFCC00" ForeColor="Red" Font-Bold="true" />

                <%-- Today Date Styling  --%>
                <TodayDayStyle BackColor="#99FF99" ForeColor="Black" Font-Bold="true" />

                <%-- Weekend Styling --%>
                <WeekendDayStyle BackColor="#F2F2F2" ForeColor="Red" Font-Bold="true" />
            </asp:Calendar>

            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" ForeColor="Green" Font-Size="Large" ></asp:Label>
        </div>
    </form>
</body>
</html>
