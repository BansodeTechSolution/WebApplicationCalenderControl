using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormCalenderVacationDays:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }
        List<DateTime> VacationDates = new List<DateTime>()
        {
            new DateTime(2025,8,15),//Independance Day
            new DateTime(2025,10,2),//Gandi Jayanti
            new DateTime(2025,12,25)//Christmas
        };

        protected void CalenderVacation_DayRender(object sender,DayRenderEventArgs e)
        {
            if(VacationDates.Contains(e.Day.Date))
            {
                e.Cell.BackColor = System.Drawing.Color.Orange;
                e.Cell.ToolTip = "Vacation Day";
                e.Cell.Font.Bold = true;
            }

        }
    }
}