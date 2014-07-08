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
            this.singlePlayerSharedPath = new System.Windows.Forms.TextBox();
            this.multiplayerSharedPathTextBox = new System.Windows.Forms.TextBox();
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
            this.multiplayerSharedMapPathLabel.Size = new System.Drawing.Size(146, 13);
            this.multiplayerSharedMapPathLabel.TabIndex = 0;
            this.multiplayerSharedMapPathLabel.Text = "Multiplayer Shared Map Path:";
            // 
            // mainMenuPathTextBox
            // 
            this.mainMenuPathTextBox.Location = new System.Drawing.Point(15, 25);
            this.mainMenuPathTextBox.Name = "mainMenuPathTextBox";
            this.mainMenuPathTextBox.Size = new System.Drawing.Size(477, 20);
            this.mainMenuPathTextBox.TabIndex = 1;
            // 
            // singlePlayerSharedPath
            // 
            this.singlePlayerSharedPath.Location = new System.Drawing.Point(16, 64);
            this.singlePlayerSharedPath.Name = "singlePlayerSharedPath";
            this.singlePlayerSharedPath.Size = new System.Drawing.Size(476, 20);
            this.singlePlayerSharedPath.TabIndex = 1;
            this.singlePlayerSharedPath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // multiplayerSharedPathTextBox
            // 
            this.multiplayerSharedPathTextBox.Location = new System.Drawing.Point(16, 103);
            this.multiplayerSharedPathTextBox.Name = "multiplayerSharedPathTextBox";
            this.multiplayerSharedPathTextBox.Size = new System.Drawing.Size(476, 20);
            this.multiplayerSharedPathTextBox.TabIndex = 1;
            // 
            // configEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 135);
            this.Controls.Add(this.multiplayerSharedPathTextBox);
            this.Controls.Add(this.singlePlayerSharedPath);
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
        private System.Windows.Forms.TextBox singlePlayerSharedPath;
        private System.Windows.Forms.TextBox multiplayerSharedPathTextBox;
    }
}