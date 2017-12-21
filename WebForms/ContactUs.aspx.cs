using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlackLight.Recruitment.WebForms.Checks;

namespace BlackLight.Recruitment.WebForms
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ContactUsBtnClick(object sender, EventArgs e)
        {
            ContactFormPanel.Attributes.Add("style", "display:none");

            if (Name.Text == Check.CheckName)
                extraFeedbackText.Text = Check.CheckName + ", ";

            FeedbackPanel.Visible = true;


        }


        // Todo: Handle the button click event and show the feedback message
    }
}