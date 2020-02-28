using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FarmerRun
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Howto();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Credit();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}
