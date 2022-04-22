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
    public partial class NewSite : Form
    {
        public NewSite()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sites (name, namePrint, priceGroup, status) VALUES (@name, @namePrint, @priceGroup, @status)", conn);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@namePrint", namePrintBox.Text);
                cmd.Parameters.AddWithValue("@priceGroup", priceGroupBox.Text);
                cmd.Parameters.AddWithValue("@status", statusBox.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Site added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
