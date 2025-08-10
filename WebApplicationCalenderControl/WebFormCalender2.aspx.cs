using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormCalender2:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }
        // List of vacation dates (you can replace these with actual dates)
        List<DateTime> vacationDates = new List<DateTime>()
    {
        new DateTime(2025, 8, 15),  // Independence Day
        new DateTime(2025, 10, 2),  // Gandhi Jayanti
        new DateTime(2025, 12, 25)  // Christmas
    };
        protected void Calendar1_DayRender(object sender,DayRenderEventArgs e)
        {
            if(vacationDates.Contains(e.Day.Date))
            {
                // Change background and add tooltip
                e.Cell.BackColor = System.Drawing.Color.Orange;
                e.Cell.ToolTip = "Vacation Day!";
                e.Cell.Font.Bold = true;
            }
        }
    }
}