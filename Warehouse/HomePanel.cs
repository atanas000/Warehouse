using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Exit";
        }

        private void salesBtn_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Sales";
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void salesBtn_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillSettingsFile.ReadFile();
        }
    }
}
