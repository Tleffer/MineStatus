using MineStatLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Status
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void get_status_Click(object sender, EventArgs e)
        {
            if(port_box.Text == "")
            {
                port_box.Text = "25565";
            }
            try
            {
                Convert.ToUInt16(port_box.Text);
            }
            catch 
            {
                MessageBox.Show("'" + port_box.Text + "' is not a valid port");
                port_box.Text = "";
                return;
            }
            MineStat mcstatus = new MineStat(ip_box.Text, Convert.ToUInt16(port_box.Text));
            if(mcstatus.ServerUp)
            {
                status.Text = ip_box.Text + " is online";
                status.BackColor = Color.Green;
                pl_o.Text = mcstatus.CurrentPlayers;
            } else
            {
                status.Text = ip_box.Text + " is offline";
                status.BackColor = Color.Red;
                pl_o.Text = "n/a";
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menu menu_window = new menu();
            menu_window.Show();
        }
    }
}
