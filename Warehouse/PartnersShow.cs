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
    public partial class PartnersShow : Form
    {
        public PartnersShow()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM partners", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void PartnersShow_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Partner = item.Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NewPartner newPartner = new NewPartner();
            newPartner.FormClosing += new FormClosingEventHandler(this.newPartner_FormClosing);
            newPartner.Show();
        }
        private void newPartner_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditPartner editPartner = new EditPartner();
            editPartner.FormClosing += new FormClosingEventHandler(this.editPartner_FormClosing);
            editPartner.Show();
        }
        private void editPartner_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                Data.Partner = item.Cells[1].Value.ToString();
            }
            this.Close();
        }
    }
}
