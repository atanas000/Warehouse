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
    public partial class EditSite : Form
    {
        public EditSite()
        {
            InitializeComponent();
        }

        private void EditSite_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sites WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.IDSite);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codeBox.Text = dr["id"].ToString();
                    nameBox.Text = dr["name"].ToString();
                    namePrintBox.Text = dr["namePrint"].ToString();
                    priceGroupBox.Text = dr["priceGroup"].ToString();
                    statusBox.Text = dr["status"].ToString();
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE sites SET name=@name, namePrint=@namePrint, priceGroup=@priceGroup, status=@status", conn);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@namePrint", namePrintBox.Text);
                cmd.Parameters.AddWithValue("@priceGroup", priceGroupBox.Text);
                cmd.Parameters.AddWithValue("@status", statusBox.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Site edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
    }
}
