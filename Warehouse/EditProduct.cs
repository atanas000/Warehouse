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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", ProductsShow.ProductID);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codeBox.Text = dr["id"].ToString();
                    nameBox.Text = dr["name"].ToString();
                    namePrint.Text = dr["namePrint"].ToString();
                    barcodeBox.Text = dr["barcode"].ToString();
                    descBox.Text = dr["description"].ToString();
                    statusBox.Text = dr["status"].ToString();
                    measureBox.Text = dr["measure"].ToString();
                    typeBox.Text = dr["type"].ToString();
                    VATGroupBox.Text = dr["VATgroup"].ToString();
                    wholesalePrice.Text = dr["wholesalePrice"].ToString();
                    retailPrice.Text = dr["retailPrice"].ToString();
                }
            }
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
                MySqlCommand cmd = new MySqlCommand("UPDATE products SET name=@name, namePrint=@namePrint, barcode=@barcode, description=@description, status=@status, measure=@measure, type=@type, VATgroup=@VATgroup, wholesalePrice=@wholesalePrice, retailPrice=@retailPrice WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", ProductsShow.ProductID);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@namePrint", namePrint.Text);
                cmd.Parameters.AddWithValue("@barcode", barcodeBox.Text);
                cmd.Parameters.AddWithValue("@description", descBox.Text);
                cmd.Parameters.AddWithValue("@status", statusBox.Text);
                cmd.Parameters.AddWithValue("@measure", measureBox.Text);
                cmd.Parameters.AddWithValue("@type", typeBox.Text);
                cmd.Parameters.AddWithValue("@VATgroup", VATGroupBox.Text);
                cmd.Parameters.AddWithValue("@wholesalePrice", wholesalePrice.Text);
                cmd.Parameters.AddWithValue("@retailPrice", retailPrice.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Product edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
