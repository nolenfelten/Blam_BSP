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
    public partial class configEditor : Form
    {
        public configEditor()
        {
            InitializeComponent();
            mainMenuPathTextBox.Text = ConfigurationManager.AppSettings["main_menu_path"];
            singlePlayerSharedPathTextBox.Text = ConfigurationManager.AppSettings["sp_shared_path"];
            multiplayerSharedPathTextBox.Text = ConfigurationManager.AppSettings["mp_shared_path"];
        }    

        private void loadMainMenuButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog loadMainMenuDialog = new OpenFileDialog();
            loadMainMenuDialog.Title = "Select Main Menu map location";

            // Set filter options and filter index.
            loadMainMenuDialog.Filter = "Halo 2 Main Menu (.map)|mainmenu.map";
            loadMainMenuDialog.FilterIndex = 1;

            loadMainMenuDialog.Multiselect = false;

            // Process input if the user clicked OK.
            if (loadMainMenuDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected setting's text field to the file's path.
                mainMenuPathTextBox.Text = loadMainMenuDialog.FileName;
            }
        }

        private void loadSinglePlayerSharedButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog loadSinglePlayerSharedDialog = new OpenFileDialog();
            loadSinglePlayerSharedDialog.Title = "Select Single Player Shared map location";

            // Set filter options and filter index.
            loadSinglePlayerSharedDialog.Filter = "Halo 2 SP Shared (.map)|single_player_shared.map";
            loadSinglePlayerSharedDialog.FilterIndex = 1;

            loadSinglePlayerSharedDialog.Multiselect = false;

            // Process input if the user clicked OK.
            if (loadSinglePlayerSharedDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected setting's text field to the file's path.
                singlePlayerSharedPathTextBox.Text = loadSinglePlayerSharedDialog.FileName;
            }
        }

        private void loadMultiplayerSharedMapButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog loadMultiplayerSharedDialog = new OpenFileDialog();
            loadMultiplayerSharedDialog.Title = "Select Shared map location";

            // Set filter options and filter index.
            loadMultiplayerSharedDialog.Filter = "Halo 2 Shared (.map)|shared.map";
            loadMultiplayerSharedDialog.FilterIndex = 1;

            loadMultiplayerSharedDialog.Multiselect = false;

            // Process input if the user clicked OK.
            if (loadMultiplayerSharedDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected setting's text field to the file's path.
                multiplayerSharedPathTextBox.Text = loadMultiplayerSharedDialog.FileName;
            }
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            if(String.Compare(mainMenuPathTextBox.Text, "") != 0 || String.Compare(singlePlayerSharedPathTextBox.Text, "") != 0 || String.Compare(multiplayerSharedPathTextBox.Text, "") != 0)
            {
                ConfigurationManager.AppSettings["main_menu_path"] = mainMenuPathTextBox.Text;
                ConfigurationManager.AppSettings["sp_shared_path"] = singlePlayerSharedPathTextBox.Text;
                ConfigurationManager.AppSettings["mp_shared_path"] = multiplayerSharedPathTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please select valid file locations for the specified Halo 2 internal maps.");
            }
        }

        private void cancelConfigurationButton_Click(object sender, EventArgs e)
        {
            if (String.Compare(mainMenuPathTextBox.Text, "") != 0 || String.Compare(singlePlayerSharedPathTextBox.Text, "") != 0 || String.Compare(multiplayerSharedPathTextBox.Text, "") != 0)
            {
                //Do nothing
            }
            else
            {
                MessageBox.Show("Please select valid file locations for the specified Halo 2 internal maps.");
            }
        }
    }
}
