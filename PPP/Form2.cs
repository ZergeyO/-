using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPP
{
    public partial class openForm : Form
    {
        public openForm(oscilograph oscilograph_)
        {
            InitializeComponent();
            _oscilograph=oscilograph_;
    }

        private void openForm_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.adres = textBox1.Text;
            _oscilograph.Adres=adres;
            Close();
        }
    }
}
