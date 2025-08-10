using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormCalenderSelectedDayStyle:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }

        protected void Calender1_SelectionChanged(object sender,EventArgs e)
        {
            lblmsg.Text = "You Selected : " + Calender1.SelectedDate.ToLongDateString();
        }
    }
}