using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (Session["salesPrice"] == null)
            {
                
            }
            else
            {
                lblSalesPrice.Text = Convert.ToString(Session["salesPrice"]);
                lblDiscountAmount.Text = Convert.ToString(Session["discountAmount"]);
                lblTotalPrice.Text = Convert.ToString(Session["totalPrice"]);
            }
            
        }

        protected void sendQuotButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblMessage.Text = String.Format("Quation sent to {0} at {1}.", txtName.Text, txtEmail.Text);
                Session["salesPrice"] = null;
                Session["discountAmount"] = null;
                Session["totalPrice"] = null;
            }

        }
    }
}