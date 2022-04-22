using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            using (StreamReader sr = new StreamReader("Settings.txt"))
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    GettingStarted g = new GettingStarted();
                    this.Hide();
                    g.Show();
                }
                else
                {
                    FillSettingsFile.ReadFile();
                }
            }
            
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UsersShow usersShow = new UsersShow();
            usersShow.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsShow p = new ProductsShow();
            p.Show();
        }

        private void partnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartnersShow partners = new PartnersShow();
            partners.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsShow products = new ProductsShow();
            products.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersShow users = new UsersShow();
            users.Show();
        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SitesShow sites = new SitesShow();
            sites.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
