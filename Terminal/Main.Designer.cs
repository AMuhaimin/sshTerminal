namespace Terminal
{
    partial class Main
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
            this.gtpHeader = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtHostAdress = new System.Windows.Forms.TextBox();
            this.lbPortNumber = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSSHConsole = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.grpSSHTerminal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gtpHeader.SuspendLayout();
            this.grpSSHTerminal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gtpHeader
            // 
            this.gtpHeader.Controls.Add(this.btnDisconnect);
            this.gtpHeader.Controls.Add(this.txtPortNumber);
            this.gtpHeader.Controls.Add(this.txtPassword);
            this.gtpHeader.Controls.Add(this.txtUserName);
            this.gtpHeader.Controls.Add(this.txtHostAdress);
            this.gtpHeader.Controls.Add(this.lbPortNumber);
            this.gtpHeader.Controls.Add(this.lbPassword);
            this.gtpHeader.Controls.Add(this.lbUser);
            this.gtpHeader.Controls.Add(this.lbHost);
            this.gtpHeader.Controls.Add(this.btnConnect);
            this.gtpHeader.Location = new System.Drawing.Point(11, 35);
            this.gtpHeader.Name = "gtpHeader";
            this.gtpHeader.Size = new System.Drawing.Size(692, 152);
            this.gtpHeader.TabIndex = 0;
            this.gtpHeader.TabStop = false;
            this.gtpHeader.Text = "SSH Connection Info";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(570, 96);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(103, 38);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(122, 118);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(137, 20);
            this.txtPortNumber.TabIndex = 8;
            this.txtPortNumber.Text = "22";
            this.txtPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortNumber_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 66);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtHostAdress
            // 
            this.txtHostAdress.Location = new System.Drawing.Point(122, 40);
            this.txtHostAdress.Name = "txtHostAdress";
            this.txtHostAdress.Size = new System.Drawing.Size(137, 20);
            this.txtHostAdress.TabIndex = 5;
            // 
            // lbPortNumber
            // 
            this.lbPortNumber.AutoSize = true;
            this.lbPortNumber.Location = new System.Drawing.Point(34, 121);
            this.lbPortNumber.Name = "lbPortNumber";
            this.lbPortNumber.Size = new System.Drawing.Size(72, 13);
            this.lbPortNumber.TabIndex = 4;
            this.lbPortNumber.Text = "Port Number :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(34, 95);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(59, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password :";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(32, 69);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(61, 13);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Username :";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(32, 43);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(35, 13);
            this.lbHost.TabIndex = 1;
            this.lbHost.Text = "Host :";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(570, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSSHConsole
            // 
            this.txtSSHConsole.Location = new System.Drawing.Point(6, 19);
            this.txtSSHConsole.Multiline = true;
            this.txtSSHConsole.Name = "txtSSHConsole";
            this.txtSSHConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSSHConsole.Size = new System.Drawing.Size(679, 319);
            this.txtSSHConsole.TabIndex = 0;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(5, 344);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(680, 20);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // grpSSHTerminal
            // 
            this.grpSSHTerminal.Controls.Add(this.txtCommand);
            this.grpSSHTerminal.Controls.Add(this.txtSSHConsole);
            this.grpSSHTerminal.Location = new System.Drawing.Point(12, 193);
            this.grpSSHTerminal.Name = "grpSSHTerminal";
            this.grpSSHTerminal.Size = new System.Drawing.Size(691, 370);
            this.grpSSHTerminal.TabIndex = 1;
            this.grpSSHTerminal.TabStop = false;
            this.grpSSHTerminal.Text = "SSH Terminal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status :";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(57, 570);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 14);
            this.lbStatus.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 591);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSSHTerminal);
            this.Controls.Add(this.gtpHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gtpHeader.ResumeLayout(false);
            this.gtpHeader.PerformLayout();
            this.grpSSHTerminal.ResumeLayout(false);
            this.grpSSHTerminal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gtpHeader;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtHostAdress;
        private System.Windows.Forms.Label lbPortNumber;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtSSHConsole;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.GroupBox grpSSHTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

