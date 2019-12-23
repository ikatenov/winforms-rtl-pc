using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_RightToLeft
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void checkBoxRightToLeft_CheckedChanged(object sender, EventArgs e)
    {
      this.RightToLeft = checkBoxRightToLeft.Checked ? RightToLeft.Yes : RightToLeft.No;
    }

    private void checkBoxRightToLeftLayout_CheckedChanged(object sender, EventArgs e)
    {
      this.RightToLeftLayout = checkBoxRightToLeftLayout.Checked;
    }
  }
}
