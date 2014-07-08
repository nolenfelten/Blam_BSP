using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blam_BSP
{
    public partial class configEditor : Form
    {
        public configEditor()
        {
            InitializeComponent();
            mainMenuPathTextBox.Text = System.Configuration.ConfigurationSettings.AppSettings["main_menu_path"];
            singlePlayerSharedPath.Text = System.Configuration.ConfigurationSettings.AppSettings["sp_shared_path"];
            multiplayerSharedPathTextBox.Text = System.Configuration.ConfigurationSettings.AppSettings["mp_shared_path"];
        }    

        private void loadMainMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void loadSinglePlayerSharedButton_Click(object sender, EventArgs e)
        {

        }

        private void loadMultiplayerSharedMap_Click(object sender, EventArgs e)
        {

        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mainMenuPathTextBox.Text);
            if(String.Compare(mainMenuPathTextBox.Text, "") != 0 || String.Compare(singlePlayerSharedPath.Text, "") != 0 || String.Compare(multiplayerSharedPathTextBox.Text, "") != 0)
            {
                System.Configuration.ConfigurationSettings.AppSettings["main_menu_path"] = mainMenuPathTextBox.Text;
                System.Configuration.ConfigurationSettings.AppSettings["sp_shared_path"] = singlePlayerSharedPath.Text;
                System.Configuration.ConfigurationSettings.AppSettings["mp_shared_path"] = multiplayerSharedPathTextBox.Text;
            }
            else
            {
                MessageBox.Show("You are an idiot.");
            }
        }

        private void cancelConfiguration_Click(object sender, EventArgs e)
        {

        }
    }
}
