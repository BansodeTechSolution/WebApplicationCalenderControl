using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormCalender3:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender,EventArgs e)
        {
            lblSelectedDate.Text = "You selected: " + Calendar1.SelectedDate.ToLongDateString();
        }
    }
}