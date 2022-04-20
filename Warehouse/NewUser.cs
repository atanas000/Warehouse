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
    public partial class NewUser : Form
    {
        public NewUser()
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (passBox.Text == confBox.Text)
            {
                using (MySqlConnection conn = Data.conn)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (name, role, username, password, place, cardNum, status) VALUES (@name, @role, @usr, @pass, @place, @cardNum, @status)", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@role", roleBox.Text);
                    cmd.Parameters.AddWithValue("@usr", userBox.Text);
                    cmd.Parameters.AddWithValue("@pass", passBox.Text);
                    cmd.Parameters.AddWithValue("@place", placeBox.Text);
                    cmd.Parameters.AddWithValue("@cardNum", cardNumBox.Text);
                    cmd.Parameters.AddWithValue("@status", statusBox.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
