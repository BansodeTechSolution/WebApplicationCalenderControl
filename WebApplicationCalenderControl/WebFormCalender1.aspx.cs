using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormCalender1:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }

        public static readonly Dictionary<DateTime,string> impDates = new Dictionary<DateTime,string>() {
            {new DateTime(2025,8,15),"Independence Day" },
            {new DateTime(2025,8,9),"RakshaBandhan" },
            {new DateTime(2025,8,19),"Janmashtami" },
            {new DateTime(2025,8,27),"Ganesh Chaturthi" },
                    };

        protected void Calendar1_SelectionChanged(object sender,EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            lblMessage.Text = "Your Selected: " + selectedDate.ToString("dd/MM/yyyy");
        }

        protected void Calendar1_DayRender(object sender,DayRenderEventArgs e)
        {
            if(impDates.ContainsKey(e.Day.Date))
            {
                //e.Cell.BackColor = System.Drawing.Color.RoyalBlue;
                e.Cell.Controls.Add(new LiteralControl("<br/> <span style='color:red;'>" + impDates[e.Day.Date] + "</span>"));
            }
        }
    }
}