using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Blam_BSP
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            if (String.Compare(System.Configuration.ConfigurationSettings.AppSettings["main_menu_path"], "") == 0 || String.Compare(System.Configuration.ConfigurationSettings.AppSettings["sp_shared_path"], "") == 0 || String.Compare(System.Configuration.ConfigurationSettings.AppSettings["mp_shared_path"], "") == 0)
            {
                configEditor updateConfig = new configEditor();
                updateConfig.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load BSP");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
