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
    public partial class NewPartner : Form
    {
        public NewPartner()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO partners (company, owner, city, address, phone, idNum, VATNum, status, email, bankName, bic, iban, bankVat, priceGroup, discount, type, cardNum, payInDays, companyPrint, ownerPrint, cityPrint, addressPrint, phonePrint, comment1Print, comment2Print) VALUES (@company, @owner, @city, @address, @phone, @idNum, @VATNum, @status, @email, @bankName, @bic, @iban, @bankVat, @priceGroup, @discount, @type, @cardNum, @payInDays, @companyPrint, @ownerPrint, @cityPrint, @addressPrint, @phonePrint, @comment1Print, @comment2Print)", conn);
                cmd.Parameters.AddWithValue("@company",companyBox.Text);
                cmd.Parameters.AddWithValue("@owner",ownerBox.Text);
                cmd.Parameters.AddWithValue("@city",cityBox.Text);
                cmd.Parameters.AddWithValue("@address",addressBox.Text);
                cmd.Parameters.AddWithValue("@phone",phoneBox.Text);
                cmd.Parameters.AddWithValue("@idNum",idNumBox.Text);
                cmd.Parameters.AddWithValue("@VATNum",vatNumBox.Text);
                cmd.Parameters.AddWithValue("@status",statusBox.Text);
                cmd.Parameters.AddWithValue("@email",emailBox.Text);
                cmd.Parameters.AddWithValue("@bankName",bankBox.Text);
                cmd.Parameters.AddWithValue("@bic",bicBox.Text);
                cmd.Parameters.AddWithValue("@iban",ibanBox.Text);
                cmd.Parameters.AddWithValue("@bankVat",bankVATBox.Text);
                cmd.Parameters.AddWithValue("@priceGroup",priceGroupBox.Text);
                cmd.Parameters.AddWithValue("@discount",discountBox.Text);
                cmd.Parameters.AddWithValue("@type",typeBox.Text);
                cmd.Parameters.AddWithValue("@cardNum",cardNum2Box.Text);
                cmd.Parameters.AddWithValue("@payInDays",payinBox.Text);
                cmd.Parameters.AddWithValue("@companyPrint", companyPrintBox.Text);
                cmd.Parameters.AddWithValue("@ownerPrint",ownerPrintBox.Text);
                cmd.Parameters.AddWithValue("@cityPrint",cityPrintBox.Text);
                cmd.Parameters.AddWithValue("@addressPrint",addressPrintBox.Text);
                cmd.Parameters.AddWithValue("@phonePrint",phonePrintBox.Text);
                cmd.Parameters.AddWithValue("@comment1Print",comment1PrintBox.Text);
                cmd.Parameters.AddWithValue("@comment2Print",comment2PrintBox.Text);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Partner added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
