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
    public partial class ProductsShow : Form
    {
        public static string ProductID;
        public void GetData()
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
        }
        public ProductsShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortBox.SelectedIndex == 0)
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
            else if (sortBox.SelectedIndex == 1)
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (sortBox.SelectedIndex == 2)
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else if (sortBox.SelectedIndex == 3)
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (sortBox.SelectedIndex == 4)
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void groupsChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (groupsChBox.Checked == false)
            {
                groupsPanel.Visible = false;
                dataGridView1.Location = new Point(12, 13);
                dataGridView1.Size = new Size(482, 353);
                dataGridView1.Columns["name"].MinimumWidth = 280;
                dataGridView1.Columns["name"].Width = 280;

            }
            else
            {
                groupsPanel.Visible = true;
                dataGridView1.Location = new Point(143, 13);
                dataGridView1.Size = new Size(356, 353);
                dataGridView1.Columns["name"].MinimumWidth = 150;
                dataGridView1.Columns["name"].Width = 150;
            }
        }

        private void ProductsShow_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                ProductID = Convert.ToString(selectedRow.Cells["code"].Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = Data.conn)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ProductID);
                    cmd.ExecuteNonQuery();
                }
            }
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.FormClosing += new FormClosingEventHandler(this.newProduct_FormClosing);
            newProduct.Show();
        }
        private void newProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            editProduct.FormClosing += new FormClosingEventHandler(this.editProduct_FormClosing);
            editProduct.Show();
        }
        private void editProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetData();
        }
    }
}
