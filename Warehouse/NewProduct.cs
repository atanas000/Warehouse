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
    public partial class NewProduct : Form
    {
        public NewProduct()
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO products (name, namePrint, barcode, description, status, measure, type, VATgroup, wholesalePrice, retailPrice) VALUES (@name, @namePrint, @barcode, @description, @status, @measure, @type, @VATgroup, @wholesalePrice, @retailPrice)", conn);
                cmd.Parameters.AddWithValue("@name",nameBox.Text);
                cmd.Parameters.AddWithValue("@namePrint",namePrint.Text);
                cmd.Parameters.AddWithValue("@barcode",barcodeBox.Text);
                cmd.Parameters.AddWithValue("@description",descBox.Text);
                cmd.Parameters.AddWithValue("@status",statusBox.Text);
                cmd.Parameters.AddWithValue("@measure",measureBox.Text);
                cmd.Parameters.AddWithValue("@type",typeBox.Text);
                cmd.Parameters.AddWithValue("@VATgroup",VATGroupBox.Text);
                cmd.Parameters.AddWithValue("@wholesalePrice",wholesalePrice.Text);
                cmd.Parameters.AddWithValue("@retailPrice",retailPrice.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
