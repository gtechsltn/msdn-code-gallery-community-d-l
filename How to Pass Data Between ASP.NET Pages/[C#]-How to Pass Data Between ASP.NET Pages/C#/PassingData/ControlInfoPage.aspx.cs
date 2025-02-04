﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PassingData
{
    public partial class ControlInfoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var textbox = PreviousPage.FindControl("DataToSendTextbox") as TextBox;
            if (textbox != null)
            {
                DataReceivedLabel.Text = textbox.Text;
            }
        }
    }
}