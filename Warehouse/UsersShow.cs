using MySql.Data.MySqlClient;
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

    public partial class UsersShow : Form
    {
        public static string user;

        public void GetData()
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;
            }
        }
        public UsersShow()
        {
            InitializeComponent();
        }

        private void UsersShow_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Name = item.Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Name = item.Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.FormClosing += new FormClosingEventHandler(this.newUser_FormClosing);
            newUser.Show();
        }

        private void newUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = Data.conn)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", Data.IDUser);
                    cmd.ExecuteNonQuery();
                }
            }
            GetData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Data.IDUser = Convert.ToInt32(selectedRow.Cells["code"].Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.FormClosing += new FormClosingEventHandler(this.EditUser_FormClosing);
            editUser.Show();
        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }
    }
}
