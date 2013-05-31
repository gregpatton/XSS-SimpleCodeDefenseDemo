using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace XSS_SimpleCodeDefenseDemo
{
    public partial class XSS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void cmdBad_Click(object sender, EventArgs e) {
            Response.Write("The input provided was " + txtInput.Text);
        }

        protected void cmdBetter_Click(object sender, EventArgs e) {
            Response.Write("The input provided was " + Server.HtmlEncode(txtInput.Text));
        }

        protected void cmdBest_Click(object sender, EventArgs e) {
            string pattern = @"\(?(\d{3})\)?-?(\d{3})-(\d{4})";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(txtInput.Text);
            if (m.Success) {
                Response.Write("The input provided was " + Server.HtmlEncode(txtInput.Text));
            }
            else {
                Response.Write("The input provided was invalid.  Please provide a valid phone number.");
            }
        }
    }
}