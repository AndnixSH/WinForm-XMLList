using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace winform_test
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xm = new XmlDocument();
            string list = "//Data";

            xm.Load("test.xml");
            XmlNodeList Xn = xm.SelectNodes(list);

            foreach (XmlNode xNode in Xn)
            {
                listBox1.Items.Add(xNode.InnerText);
            }
        }
    }
}
