using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalenderControl
{
    public partial class WebFormDayDifference:System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {

        }
        static DateTime FirstDate;
        static DateTime SecondDate;
        protected void Calendar1_SelectionChanged(object sender,EventArgs e)
        {
            FirstDate = Calendar1.SelectedDate;
            calculateDifferece();
        }

        protected void Calendar2_SelectionChanged(object sender,EventArgs e)
        {
            SecondDate = Calendar2.SelectedDate;
            calculateDifferece();

        }

        private void calculateDifferece()
        {
            if(FirstDate != DateTime.MinValue && SecondDate != DateTime.MinValue)
            {
                TimeSpan difference = SecondDate - FirstDate;
                lblResult.Text = "The difference between the two dates is: " + Math.Abs(difference.Days) + " days";
            }
            else
            {

                lblResult.Text = "Please select both dates to calculate the difference.";
            }
        }
    }
}