using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace Terminal
{
    public partial class Main : Form
    {
        private SshClient sshClient = null;
        private ShellStream shellStreamSSH = null;
        public Main()
        {
            InitializeComponent();
        }

        // Connect Button
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHostAdress.Text) || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPortNumber.Text))
                {
                    MessageBox.Show("Please check host, port and username field");
                }
                else
                {
                    this.sshClient = new SshClient(txtHostAdress.Text, Convert.ToInt32(txtPortNumber.Text), txtUserName.Text, txtPassword.Text);

                    this.sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(120);
                    this.sshClient.Connect();

                    this.shellStreamSSH = this.sshClient.CreateShellStream("vt-100", 80, 60, 800, 600, 65536);
                    this.lbStatus.Text = " Connected to " + (txtHostAdress.Text);
                }
            }
            catch (Exception exp)
            {
                this.lbStatus.Text = " Disconnected";
                MessageBox.Show("ERROR :" + exp.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadStart threadStart = new System.Threading.ThreadStart(recvSSHData);
            System.Threading.Thread thread = new System.Threading.Thread(threadStart);

            thread.IsBackground = true;
            thread.Start();

        }

          
        private void recvSSHData ()
        {
            while (true)
            {
                try
                {
                    if (this.shellStreamSSH != null && this.shellStreamSSH.DataAvailable)
                    {
                        String strData = this.shellStreamSSH.Read();

                        appendTextBoxInThread(txtSSHConsole, strData);
                    }
                }
                catch
                {

                }

                System.Threading.Thread.Sleep(200);
            }
        }

        private void appendTextBoxInThread(TextBox t, String s)
        {
            if (t.InvokeRequired)
            {
                t.Invoke(new Action<TextBox, string>(appendTextBoxInThread), new object[] { t, s });
            }
            else
            {
                t.AppendText(s);
            }
        }
        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {

                    this.shellStreamSSH.Write(txtCommand.Text + "\n");
                    this.shellStreamSSH.Flush();

                    txtCommand.Text = "";
                    txtCommand.Focus();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please establish a connection first");
            }
        }

        //The 'X' close button
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (sshClient.IsConnected != false)
                {
                    //Close dialog box

                    DialogResult exitDialog = MessageBox.Show("You are connected to" + (txtHostAdress.Text) + " , are you sure want to disconnect ?", "Disconnect", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        this.shellStreamSSH.Close();
                        this.sshClient.Disconnect();
                        this.sshClient.Dispose();

                        this.lbStatus.Text = " Disconnected";

                        MessageBox.Show("You have disconnect");
                    }
                    // Cancel dialog box (when click 'NO'

                    else if (exitDialog == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {
                DialogResult exitDialog = MessageBox.Show("Do you really want to close the program ?", "Exit", MessageBoxButtons.YesNo);
                if (exitDialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (exitDialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //Disconnect button
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (sshClient.IsConnected != false)
                {
                    //Disconnect dialog box

                    DialogResult exitDialog = MessageBox.Show("Are you sure want to disconnect?", "Disconnect", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        this.shellStreamSSH.Close();
                        this.sshClient.Disconnect();
                        this.sshClient.Dispose();

                        this.lbStatus.Text = " Disconnected";

                        MessageBox.Show("You have disconnect from" + (txtHostAdress.Text));
                    }
                }
            }
            catch
            {
                MessageBox.Show("You are not connected");
            }

        }

        // Only permits numeric, back and delete button keys to be input in port number
        private void txtPortNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char port = e.KeyChar;

            if (!Char.IsDigit(port) && port != Convert.ToChar(Keys.Back) && port != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        // Catch 'control + c' key pressed to terminal
        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                this.shellStreamSSH.Write(txtCommand.Text + "\r");
                this.shellStreamSSH.Flush();

                txtCommand.Text = "\u0003";
                txtCommand.Focus();
                //e.SuppressKeyPress = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f2 = new About();
            f2.ShowDialog();
        }
    }
}
