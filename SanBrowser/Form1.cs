using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

                try
                {
                     webBrowser.Navigate(new Uri(txtUrl.Text.ToString()));
                txtUrl.Text = "http://www";
                txtUrl.Text = txtUrl.Text;
                }
                catch (Exception )
                {

                    MessageBox.Show("Please make sure you are entering the URL with http://www","Incorrect URl Entered", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUrl.Text = "http://www";


                }
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
         //   webBrowser.Navigate("file://temp.html");

          //  webBrowser.Url = new Uri("file://\\temp.html");
          


           //  string curDir = Directory.GetCurrentDirectory();
           //  this.webBrowser.Url = new Uri(String.Format(@"C:\Users\aSangam\documents\visual studio 2013\Projects\SanBrowser\SanBrowser\temp.html", curDir));
            /* 
             Supposing that there is a file called temp.html in the directory listed as above
             * still adressing with the direct file name is unknown
             */
        }

        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            webBrowser.Navigate(webBrowser.StatusText);
            //Force all ink to open in the same window
            //No external internet explorer or any browser
            //popping up
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }   

    }
}
    
