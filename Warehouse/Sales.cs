using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Warehouse
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            userBox.Text = Data.Name;
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT name FROM users WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.Name);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    userBox.Text = dr[0].ToString();
                }
            }
        }

        private void userShow_Click(object sender, EventArgs e)
        {
            UsersShow u = new UsersShow();
            u.FormClosing += new FormClosingEventHandler(this.US_FormClosing);
            u.Show();
        }
        private void US_FormClosing(object sender, FormClosingEventArgs e)
        {
            userBox.Text = Data.Name;
        }

        private void partnerShow_Click(object sender, EventArgs e)
        {
            PartnersShow partners = new PartnersShow();
            partners.FormClosing += new FormClosingEventHandler(this.pS_FormClosing);
            partners.Show();
        }
        private void pS_FormClosing(object sender, FormClosingEventArgs e)
        {
            partnerBox.Text = Data.Partner;
        }

        private void locationShow_Click(object sender, EventArgs e)
        {
            SitesShow sites = new SitesShow();
            sites.FormClosing += new FormClosingEventHandler(this.sites_FormClosing);
            sites.Show();
        }
        private void sites_FormClosing(object sender, FormClosingEventArgs e)
        {
            locationBox.Text = Data.Site;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                
                Button b1 = new Button();
                b1.Text = "...";
                b1.Size = new Size(25, 18);
                b1.Location = new Point(531, 231);
            }
            
        }
    }
}
