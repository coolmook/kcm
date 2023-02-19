using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://qsm.qoo10.jp/GMKT.INC.Gsm.Web/QSpecial/QSpecialPlus.aspx");
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("txtLoginID").SetAttribute("value", "tirtir2");
            webBrowser1.Document.GetElementById("txtLoginPwd").SetAttribute("value", "0708aaAAa"); 
        }
    }
}
