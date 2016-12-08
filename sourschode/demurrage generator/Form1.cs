using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demurrage_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        { //Error
            MessageBox.Show("there was an error it appears you cannot be sent any demurrage at this time", "Error");
        }
    }
}
