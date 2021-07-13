using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nForm
{
    public partial class nForm : Form
    {
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckBoxClose.Checked) return;
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }
        private bool nclose = false;
  
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }
        public new void Close()
        {
            nclose = true;
            base.Close();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
