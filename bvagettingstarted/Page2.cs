using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bvagettingstarted
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void sc2op1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.bvartcc.com/GettingStarted/start.html");
            Close();
        }

        private void sc2op2_MouseEnter(object sender, EventArgs e)
        {
            sc2op2.ForeColor = Color.White;
        }

        private void sc2op2_Click(object sender, EventArgs e)
        {
            Hide();
            Page3 frm = new Page3();
            frm.Show();
        }
    }
}
