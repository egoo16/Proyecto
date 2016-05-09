using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splath
{
    public partial class NotasES : Form
    {
        public NotasES()
        {
            InitializeComponent();
        }

        private void NotasES_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
