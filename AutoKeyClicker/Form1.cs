using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;


namespace AutoKeyClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Hotkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
                                          // You can edit this to make it better or change the hotkeys!
            if (e.KeyCode == Keys.F4)
            {
                button4.PerformClick();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            string message = "Do you want to join my discord server?";
            string title = "Discord server";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://discord.gg/sCHV2q9p");
            }
            else
            {
                //pass 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GtMod.Checked)
            {
                int del1 = 0;
                int.TryParse(Delay.Text, out del1);
                SendKeys.Send("{Enter}");
                SendKeys.Send(Spam.Text);
                SendKeys.Send("{Enter}");
                Thread.Sleep(del1);
                return;
            }
            int del = 0;
            int.TryParse(Delay.Text, out del);
            SendKeys.Send(Spam.Text);
            Thread.Sleep(del);
            return;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
