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
    public partial class SitesShow : Form
    {
        public void GetData()
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sites", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
        }
        public SitesShow()
        {
            InitializeComponent();
        }

        private void groupsChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (groupsChBox.Checked == false)
            {
                groupsPanel.Visible = false;
                dataGridView1.Location = new Point(12, 13);
                dataGridView1.Size = new Size(482, 353);
                dataGridView1.Columns[1].MinimumWidth = 280;
                dataGridView1.Columns[1].Width = 280;

            }
            else
            {
                groupsPanel.Visible = true;
                dataGridView1.Location = new Point(143, 13);
                dataGridView1.Size = new Size(356, 353);
                dataGridView1.Columns[1].MinimumWidth = 150;
                dataGridView1.Columns[1].Width = 150;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void SitesShow_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Data.IDSite = Convert.ToString(selectedRow.Cells["code"].Value);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Site = item.Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Site = item.Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NewSite newSite = new NewSite();
            newSite.FormClosing += new FormClosingEventHandler(this.newSite_FormClosing);
            newSite.Show();
        }
        private void newSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete this site?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = Data.conn)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM sites WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", Data.IDSite);
                    cmd.ExecuteNonQuery();
                }
            }
            GetData();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditSite editSite = new EditSite();
            editSite.FormClosing += new FormClosingEventHandler(this.editSite_FormClosing);
            editSite.Show();
        }
        private void editSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }
    }
}
