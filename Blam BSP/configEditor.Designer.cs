namespace Blam_BSP
{
    partial class configEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuPathLabel = new System.Windows.Forms.Label();
            this.singlePlayerSharedPathLabel = new System.Windows.Forms.Label();
            this.multiplayerSharedMapPathLabel = new System.Windows.Forms.Label();
            this.mainMenuPathTextBox = new System.Windows.Forms.TextBox();
            this.singlePlayerSharedPathTextBox = new System.Windows.Forms.TextBox();
            this.multiplayerSharedPathTextBox = new System.Windows.Forms.TextBox();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.loadMainMenuButton = new System.Windows.Forms.Button();
            this.loadSinglePlayerSharedButton = new System.Windows.Forms.Button();
            this.loadMultiplayerSharedMapButton = new System.Windows.Forms.Button();
            this.cancelConfigurationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuPathLabel
            // 
            this.mainMenuPathLabel.AutoSize = true;
            this.mainMenuPathLabel.Location = new System.Drawing.Point(13, 9);
            this.mainMenuPathLabel.Name = "mainMenuPathLabel";
            this.mainMenuPathLabel.Size = new System.Drawing.Size(88, 13);
            this.mainMenuPathLabel.TabIndex = 0;
            this.mainMenuPathLabel.Text = "Main Menu Path:";
            // 
            // singlePlayerSharedPathLabel
            // 
            this.singlePlayerSharedPathLabel.AutoSize = true;
            this.singlePlayerSharedPathLabel.Location = new System.Drawing.Point(12, 48);
            this.singlePlayerSharedPathLabel.Name = "singlePlayerSharedPathLabel";
            this.singlePlayerSharedPathLabel.Size = new System.Drawing.Size(133, 13);
            this.singlePlayerSharedPathLabel.TabIndex = 0;
            this.singlePlayerSharedPathLabel.Text = "Single Player Shared Path:";
            // 
            // multiplayerSharedMapPathLabel
            // 
            this.multiplayerSharedMapPathLabel.AutoSize = true;
            this.multiplayerSharedMapPathLabel.Location = new System.Drawing.Point(12, 87);
            this.multiplayerSharedMapPathLabel.Name = "multiplayerSharedMapPathLabel";
            this.multiplayerSharedMapPathLabel.Size = new System.Drawing.Size(69, 13);
            this.multiplayerSharedMapPathLabel.TabIndex = 0;
            this.multiplayerSharedMapPathLabel.Text = "Shared Path:";
            // 
            // mainMenuPathTextBox
            // 
            this.mainMenuPathTextBox.Location = new System.Drawing.Point(15, 25);
            this.mainMenuPathTextBox.Name = "mainMenuPathTextBox";
            this.mainMenuPathTextBox.ReadOnly = true;
            this.mainMenuPathTextBox.Size = new System.Drawing.Size(395, 20);
            this.mainMenuPathTextBox.TabIndex = 1;
            // 
            // singlePlayerSharedPathTextBox
            // 
            this.singlePlayerSharedPathTextBox.Location = new System.Drawing.Point(16, 64);
            this.singlePlayerSharedPathTextBox.Name = "singlePlayerSharedPathTextBox";
            this.singlePlayerSharedPathTextBox.ReadOnly = true;
            this.singlePlayerSharedPathTextBox.Size = new System.Drawing.Size(394, 20);
            this.singlePlayerSharedPathTextBox.TabIndex = 1;
            // 
            // multiplayerSharedPathTextBox
            // 
            this.multiplayerSharedPathTextBox.Location = new System.Drawing.Point(16, 103);
            this.multiplayerSharedPathTextBox.Name = "multiplayerSharedPathTextBox";
            this.multiplayerSharedPathTextBox.ReadOnly = true;
            this.multiplayerSharedPathTextBox.Size = new System.Drawing.Size(394, 20);
            this.multiplayerSharedPathTextBox.TabIndex = 1;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(15, 136);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(220, 31);
            this.saveConfigButton.TabIndex = 2;
            this.saveConfigButton.Text = "Save Configuration";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // loadMainMenuButton
            // 
            this.loadMainMenuButton.Location = new System.Drawing.Point(416, 25);
            this.loadMainMenuButton.Name = "loadMainMenuButton";
            this.loadMainMenuButton.Size = new System.Drawing.Size(75, 20);
            this.loadMainMenuButton.TabIndex = 3;
            this.loadMainMenuButton.Text = "Select...";
            this.loadMainMenuButton.UseVisualStyleBackColor = true;
            this.loadMainMenuButton.Click += new System.EventHandler(this.loadMainMenuButton_Click);
            // 
            // loadSinglePlayerSharedButton
            // 
            this.loadSinglePlayerSharedButton.Location = new System.Drawing.Point(416, 64);
            this.loadSinglePlayerSharedButton.Name = "loadSinglePlayerSharedButton";
            this.loadSinglePlayerSharedButton.Size = new System.Drawing.Size(75, 20);
            this.loadSinglePlayerSharedButton.TabIndex = 3;
            this.loadSinglePlayerSharedButton.Text = "Select...";
            this.loadSinglePlayerSharedButton.UseVisualStyleBackColor = true;
            this.loadSinglePlayerSharedButton.Click += new System.EventHandler(this.loadSinglePlayerSharedButton_Click);
            // 
            // loadMultiplayerSharedMapButton
            // 
            this.loadMultiplayerSharedMapButton.Location = new System.Drawing.Point(416, 103);
            this.loadMultiplayerSharedMapButton.Name = "loadMultiplayerSharedMapButton";
            this.loadMultiplayerSharedMapButton.Size = new System.Drawing.Size(75, 20);
            this.loadMultiplayerSharedMapButton.TabIndex = 3;
            this.loadMultiplayerSharedMapButton.Text = "Select...";
            this.loadMultiplayerSharedMapButton.UseVisualStyleBackColor = true;
            this.loadMultiplayerSharedMapButton.Click += new System.EventHandler(this.loadMultiplayerSharedMapButton_Click);
            // 
            // cancelConfigurationButton
            // 
            this.cancelConfigurationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelConfigurationButton.Location = new System.Drawing.Point(271, 136);
            this.cancelConfigurationButton.Name = "cancelConfigurationButton";
            this.cancelConfigurationButton.Size = new System.Drawing.Size(220, 31);
            this.cancelConfigurationButton.TabIndex = 2;
            this.cancelConfigurationButton.Text = "Cancel";
            this.cancelConfigurationButton.UseVisualStyleBackColor = true;
            this.cancelConfigurationButton.Click += new System.EventHandler(this.cancelConfigurationButton_Click);
            // 
            // configEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 180);
            this.Controls.Add(this.loadMultiplayerSharedMapButton);
            this.Controls.Add(this.loadSinglePlayerSharedButton);
            this.Controls.Add(this.loadMainMenuButton);
            this.Controls.Add(this.cancelConfigurationButton);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.multiplayerSharedPathTextBox);
            this.Controls.Add(this.singlePlayerSharedPathTextBox);
            this.Controls.Add(this.mainMenuPathTextBox);
            this.Controls.Add(this.multiplayerSharedMapPathLabel);
            this.Controls.Add(this.singlePlayerSharedPathLabel);
            this.Controls.Add(this.mainMenuPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "configEditor";
            this.Text = "Blam BSP | Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuPathLabel;
        private System.Windows.Forms.Label singlePlayerSharedPathLabel;
        private System.Windows.Forms.Label multiplayerSharedMapPathLabel;
        private System.Windows.Forms.TextBox mainMenuPathTextBox;
        private System.Windows.Forms.TextBox singlePlayerSharedPathTextBox;
        private System.Windows.Forms.TextBox multiplayerSharedPathTextBox;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.Button loadMainMenuButton;
        private System.Windows.Forms.Button loadSinglePlayerSharedButton;
        private System.Windows.Forms.Button loadMultiplayerSharedMapButton;
        private System.Windows.Forms.Button cancelConfigurationButton;
    }
}