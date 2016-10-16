using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SanBrowser
{
    public partial class Form1 : Form

     
    {
              public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //When Enter key is press after entering the URL the code down below executes
                // and the desired page opens
              
                webBrowser.Navigate(new Uri(txtUrl.Text.ToString()));
                txtUrl.Text = "http://www";
                txtUrl.Text = txtUrl.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri("http://bing.com"));
           // webBrowser.Navigate("index.html");


            // string curDir = Directory.GetCurrentDirectory();
            //  this.webBrowser.Url = new Uri(String.Format("file:///index.html", curDir));
        }

        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            webBrowser.Navigate(webBrowser.StatusText);
            //Force all ink to open in the same window
            //No external internet explorer or any browser
            //popping up
        }   

    }
}
    
