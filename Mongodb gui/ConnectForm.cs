using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mongodb_gui
{
    public partial class ConnectForm : Form
    {
        MainForm parent;
        public ConnectForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = this.ipBox.Text.ToString();
            string port = this.portBox.Text.ToString();
            MMongoDB mongo = new MMongoDB();
            if (ip == "" && port == "")
            {
                mongo.ConnectUsingIPAndPort();
            }
            else
            {
                mongo.ConnectUsingIPAndPort(ip, port);
            }
                       
            if (mongo.connected)
            {
#if DEBUG
                Console.WriteLine("Connected to server.");
#endif
                this.Header.Text = "Connected!";
                this.parent.mongo = mongo;
                this.Close();

            }
            else
            {
                MessageBox.Show("Check your ip and port", "Cant connect to server");
#if DEBUG
                Console.WriteLine("No connection to server.");
#endif
            }
        }

        private void useIPAndPort_Click(object sender, EventArgs e)
        {
            this.useURLPanel.Visible = false;
            this.useIPAndPortPanel.Visible = true;
        }

        private void useURLButton_Click_1(object sender, EventArgs e)
        {
            this.useURLPanel.Visible = true;
            this.useIPAndPortPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = this.urlBox.Text.ToString();
            MMongoDB mongo;
            if (url == "")
            {
                // mongo = new MMongoDB();
                return;
            }
            else
            {
                mongo = new MMongoDB();
            }
            mongo.ConnectUsingURL(url);

            if (mongo.connected)
            {
#if DEBUG
                Console.WriteLine("Connected to server.");
#endif
                this.Header.Text = "Connected!";
                this.parent.mongo = mongo;
                this.Close();

            }
            else
            {
                MessageBox.Show("Check your url", "Cant connect to server");
#if DEBUG
                Console.WriteLine("No connection to server.");
#endif
            }
        }
    }
}
