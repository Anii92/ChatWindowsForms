using Business.Logic;
using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ChatWindowsForms
{
    public partial class Form1 : Form
    {
        private IChatBusiness chatBusiness;
        private string currentUserName;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.chatBusiness = new ChatBusiness();
            List<string> users = this.chatBusiness.GetAllUsersWithConversation();
            this.comboBoxListUsers.DataSource = users;
            this.currentUserName = this.chatBusiness.GetCurrentUserName();
            this.lblCurrentUser.Text = this.currentUserName;
            this.InitTimer();
        }

        
        public void InitTimer()
        {
            this.timer = new System.Timers.Timer(1000);
            this.timer.Elapsed += new ElapsedEventHandler(this.CheckQueue);
            this.timer.Enabled = true;
            this.timer.Start();
        }

        private void CheckQueue(object sender, EventArgs e)
        {
            string message = this.chatBusiness.ReceiveMessage(this.currentUserName);
            if (message != "")
            {
                BeginInvoke(new Action(() =>
                {
                    StringBuilder builder = new StringBuilder();
                    if (this.textBoxShowMessage.Text != "")
                    {
                        builder.Append(this.textBoxShowMessage.Text);
                        builder.AppendLine();
                    }
                    builder.Append("friend: " + message);
                    this.textBoxShowMessage.Text = builder.ToString();
                }));
            }
        }

        private void comboBoxListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (this.textBoxShowMessage.Text != "")
            {
                builder.Append(this.textBoxShowMessage.Text);
                builder.AppendLine();
            }
            string message = "Me: " + this.chatBusiness.SendMessage(this.textBoxMessage.Text, this.comboBoxListUsers.Text);
            builder.Append(message);
            this.textBoxShowMessage.Text = builder.ToString();
        }
    }
}
