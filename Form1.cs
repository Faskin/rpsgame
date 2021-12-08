using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpsgame
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            Height = 400;
            Width = 800;
            Text = "Rock Paper and Scissors";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();

        }
    }
}
