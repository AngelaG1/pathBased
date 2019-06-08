using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkGUI
{
    public partial class Class1 : Form
    {
        public Class1()
        {
            InitializeComponent();
        }

        private void MultiplexImbalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                firstorder = true;
            else
                firstorder = false;


            nullModel = checkBox1.Checked;

            isValid = true;
            this.Close();
        }
        public bool isValid = false;
        public bool firstorder = true;
        public bool nullModel = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
