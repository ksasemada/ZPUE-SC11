using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = key_input.Text;
            key_out.Text = (((serial[1] + 17) * 22) * serial[serial.Length - 1] + serial[1] * serial[0] + serial[1] * serial[serial.Length - 2] + serial[1] * 3 + serial[serial.Length - 2] - 4 + serial[serial.Length - 1] * 5 + (serial[serial.Length - 2] + 3) * 7 + (serial[0] - 3) * 2 + (serial[1] + 14) * 8 + (serial[serial.Length - 1] + serial[serial.Length - 2]) * 11).ToString();
        }
    }
}
