using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Reflection; 

namespace DemoCefAd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
        private void Form1_Load_1(object sender, EventArgs e)
        {
            string path = @"Resources\index.html"; 
            Uri uri = new Uri(Path.Combine(Application.StartupPath, path));

            webBrowser1.Navigate(uri);
        }
    }
}
