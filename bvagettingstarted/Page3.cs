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
    public partial class Page3 : Form
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Page3_Load(object sender, EventArgs e)
        {
            sc3op2.Visible = false;

            // Set progress-bar value; no need to tie it to anything since our values will be time sensative
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Thread.Sleep(10000);

            //Now, search system REG_DIR for flightsim keys
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"Software\DovetailGames\FSX\"))
            {
                if (key != null)
                {
                    Object o = key.GetValue("Install_Path");
                    if (o != null)
                    {
                        sc3op2.Visible = true;
                    }
                }
            }
        }
    }
    }
}
