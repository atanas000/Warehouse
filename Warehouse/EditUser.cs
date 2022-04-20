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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.IDUser);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codeBox.Text = dr["id"].ToString();
                    nameBox.Text = dr["name"].ToString();
                    userBox.Text = dr["username"].ToString();
                    roleBox.Text = dr["role"].ToString();
                    placeBox.Text = dr["place"].ToString();
                    cardNumBox.Text = dr["cardNum"].ToString();
                    statusBox.Text = dr["status"].ToString();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET name=@name, username=@usr, role=@role, place=@place, cardNum=@cardNum, status=@status WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@role", roleBox.Text);
                cmd.Parameters.AddWithValue("@usr", userBox.Text);
                cmd.Parameters.AddWithValue("@place", placeBox.Text);
                cmd.Parameters.AddWithValue("@cardNum", cardNumBox.Text);
                cmd.Parameters.AddWithValue("@status", statusBox.Text);
                cmd.Parameters.AddWithValue("@id", Data.IDUser);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("User edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
    }
}
