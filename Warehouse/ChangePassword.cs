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
    public partial class ChangePassword : Form
    {
        public string Password { get; set; }
        public ChangePassword()
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
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT password FROM users WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.IDUser);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Password = dr[0].ToString();
                }
            }

            if (Password == currPass.Text)
            {
                if (newPass.Text == confPass.Text)
                {
                    using (MySqlConnection conn = Data.conn)
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET password=@pass WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@pass", newPass.Text);
                        cmd.Parameters.AddWithValue("@id", Data.IDUser);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Current password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            
        }
    }
}
