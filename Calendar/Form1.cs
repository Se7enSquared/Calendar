using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
  public partial class frmDate : Form
  {
    public frmDate()
    {
      InitializeComponent();
    }
        DateTime today;
        private void btnStart_Click(object sender, EventArgs e)
        {
            today = today = DateTime.Now;
            timTime.Enabled = true;
            timTime.Start();
            lblDayOfWeek.Text = today.ToString("ddd");
            lblDayOfMonth.Text = today.ToString("MM");
            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");
            lblTime.Text = today.ToLongTimeString();
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            today = DateTime.Now;
            lblDayOfWeek.Text = today.ToString("ddd");
            lblDayOfMonth.Text = today.ToString("MM");
            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.ToString("yyyy");
            lblTime.Text = today.ToLongTimeString();
        }
    }
}
