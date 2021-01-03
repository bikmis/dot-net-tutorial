using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        IGreetingRemotingService.IGreetingRemotingService client; 
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            client = (IGreetingRemotingService.IGreetingRemotingService)Activator.GetObject(typeof(IGreetingRemotingService.IGreetingRemotingService), "tcp://localhost:8080/Greet");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.Greet(textBox1.Text);
        }
    }
}
