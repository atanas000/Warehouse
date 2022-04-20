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
    }
}
