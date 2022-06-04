using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Net;

namespace Hookscord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox2.Text;
            var username = textBox1.Text;
            var content = textBox3.Text;
   
            
            DiscordSendMessage(url, username, content);
            notifyIcon1.ShowBalloonTip(1000, "Hookscord", "Discord WebhookMessage Sended Successfully", ToolTipIcon.Info);

            richTextBox1.Text = textBox3.Text;

        }

        private void DiscordSendMessage(int url, int username, int content)
        {

            throw new NotImplementedException();
        }

        public static void DiscordSendMessage(string url, string username, string content)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {

                wc.UploadValues(url, new NameValueCollection

                {
                {
                "content", content
                },
                {
                    "username", username
                }
            });
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();

            MessageBox.Show("NewFileOpened", "Message Cleared", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "||@everyone|| **Announcement**  text";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = ":emoji_classic_name: or <:custom_emoji_name:emoji_id>";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "• list 1 \n • list 2";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void newUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            textBox3.PlaceholderText = "message";
            MessageBox.Show("Your text message has been cleared", "Message Cleared", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hookscord Files (.hok)|*.hok";
            ofd.Title = "Select a file hok";



            if (ofd.ShowDialog() == DialogResult.OK)

            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);

                textBox2.Text = sr.ReadLine();
                textBox2.Text = sr.ReadLine();
                textBox2.Text = sr.ReadLine();
                textBox1.Text = sr.ReadLine();
                
                sr.Close();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Hookscord Files (.hok)|*.hok";
            sfd.Title = "Save a webhook";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                var url = textBox2.Text;
                var username = textBox1.Text;
                
                sw.Write("{\nimport {\n" + url + "\n" + username + "\n   }\n}");
                sw.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Undo();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "json Files (.json)|*.json";
            sfd.Title = "Save a json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                var url = textBox2.Text;
                var username = textBox1.Text;
                var content = textBox3.Text;
                sw.Write(@"
{
""token"": """+ url +  @""",
""message"": """ + content + @""",
""username"": """ + username + @"""
}");
                sw.Close();

            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "json Files (.json)|*.json";
            sfd.Title = "Save a json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                var url = textBox2.Text;
                var username = textBox1.Text;
                var content = textBox3.Text;
                sw.Write(@"
{
""token"": """ + url + @""",
""message"": """ + content + @""",
""username"": """ + username + @"""
}");
                sw.Close();

            }
        
    }

        private void jsoncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "json comment Files (.jsonc)|*.jsonc";
            sfd.Title = "Save a json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                var url = textBox2.Text;
                var username = textBox1.Text;
                var content = textBox3.Text;
                sw.Write(@"
{
""token"": """ + url + @""",
""message"": """ + content + @""",
""username"": """ + username + @"""
}");
                sw.Close();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Hookscord Files (.hok)|*.hok";
            sfd.Title = "Save a webhook";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                var url = textBox2.Text;
                var username = textBox1.Text;
                var content = textBox3.Text;
                sw.Write("{\nimport {\n" + url + "\n" + username + "\n" + content + "\n   }\n}");
                sw.Close();

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hookscord Files (.hok)|*.hok";
            ofd.Title = "Select a file hok";



            if (ofd.ShowDialog() == DialogResult.OK)

            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);

                textBox2.Text = sr.ReadLine();
                textBox2.Text = sr.ReadLine();
                textBox2.Text = sr.ReadLine();
                textBox1.Text = sr.ReadLine();
                textBox3.Text = sr.ReadLine();
                sr.Close();
            }
        }

        private void saveJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            button11.Show();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Show();
            button11.Hide();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to hookscord", "Hookscord", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var url = toolStripTextBox1.Text;
            var username = toolStripTextBox2.Text;
            var content = textBox3.Text;
            DiscordSendMessage(url, username, content);
        }

        private void envToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "save file";
            sfd.Filter = "env(.env)|*.env";
            sfd.FileName = "untiled.env";
           if(sfd.ShowDialog() == DialogResult.OK)
            {
                var url = textBox2.Text;
                var username = textBox1.Text;
                var content = textBox3.Text;
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write("URL=" + url + "\nCONTENT=" + content + "\nNAME=" + username);
                sw.Close();
            }
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_3(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_4(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
    }
}

