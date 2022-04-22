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
    public partial class EditPartner : Form
    {
        public EditPartner()
        {
            InitializeComponent();
        }

        private void EditPartner_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM partners WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.IDPartner);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codeBox.Text = dr["id"].ToString();
                    companyBox.Text = dr["company"].ToString();
                    ownerBox.Text = dr["owner"].ToString();
                    cityBox.Text = dr["city"].ToString();
                    addressBox.Text = dr["address"].ToString();
                    phoneBox.Text = dr["phone"].ToString();
                    idNumBox.Text = dr["idNum"].ToString();
                    vatNumBox.Text = dr["VATnum"].ToString();
                    statusBox.Text = dr["status"].ToString();
                    emailBox.Text = dr["email"].ToString();
                    bankBox.Text = dr["bankName"].ToString();
                    bicBox.Text = dr["bic"].ToString();
                    ibanBox.Text = dr["iban"].ToString();
                    bankVATBox.Text = dr["bankVat"].ToString();
                    priceGroupBox.Text = dr["priceGroup"].ToString();
                    discountBox.Text = dr["discount"].ToString();
                    typeBox.Text = dr["type"].ToString();
                    cardNum2Box.Text = dr["cardNum"].ToString();
                    payinBox.Text = dr["payInDays"].ToString();
                    companyPrintBox.Text = dr["companyPrint"].ToString();
                    ownerPrintBox.Text = dr["ownerPrint"].ToString();
                    cityPrintBox.Text = dr["cityPrint"].ToString();
                    addressPrintBox.Text = dr["addressPrint"].ToString();
                    phonePrintBox.Text = dr["phonePrint"].ToString();
                    comment1PrintBox.Text = dr["comment1Print"].ToString();
                    comment2PrintBox.Text = dr["comment2Print"].ToString();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Data.conn)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE partners SET company=@company, owner=@owner, city=@city, address=@address, phone=@phone, idNum=@idNum, VATnum=@VATNum, status=@status, email=@email, bankName=@bankName, bic=@bic, iban=@iban, bankVat=@bankVat, priceGroup=@priceGroup, discount=@discount, type=@type, cardNum=@cardNum, payInDays=@payInDays, companyPrint=@companyPrint, ownerPrint=@ownerPrint, cityPrint=@cityPrint, addressPrint=@addressPrint, phonePrint=@phonePrint, comment1Print=@comment1Print, comment2Print=@comment2Print WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Data.IDPartner);
                cmd.Parameters.AddWithValue("@company", companyBox.Text);
                cmd.Parameters.AddWithValue("@owner", ownerBox.Text);
                cmd.Parameters.AddWithValue("@city", cityBox.Text);
                cmd.Parameters.AddWithValue("@address", addressBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("@idNum", idNumBox.Text);
                cmd.Parameters.AddWithValue("@VATNum", vatNumBox.Text);
                cmd.Parameters.AddWithValue("@status", statusBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@bankName", bankBox.Text);
                cmd.Parameters.AddWithValue("@bic", bicBox.Text);
                cmd.Parameters.AddWithValue("@iban", ibanBox.Text);
                cmd.Parameters.AddWithValue("@bankVat", bankVATBox.Text);
                cmd.Parameters.AddWithValue("@priceGroup", priceGroupBox.Text);
                cmd.Parameters.AddWithValue("@discount", discountBox.Text);
                cmd.Parameters.AddWithValue("@type", typeBox.Text);
                cmd.Parameters.AddWithValue("@cardNum", cardNum2Box.Text);
                cmd.Parameters.AddWithValue("@payInDays", payinBox.Text);
                cmd.Parameters.AddWithValue("@companyPrint", companyPrintBox.Text);
                cmd.Parameters.AddWithValue("@ownerPrint", ownerPrintBox.Text);
                cmd.Parameters.AddWithValue("@cityPrint", cityPrintBox.Text);
                cmd.Parameters.AddWithValue("@addressPrint", addressPrintBox.Text);
                cmd.Parameters.AddWithValue("@phonePrint", phonePrintBox.Text);
                cmd.Parameters.AddWithValue("@comment1Print", comment1PrintBox.Text);
                cmd.Parameters.AddWithValue("@comment2Print", comment2PrintBox.Text);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Partner edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
