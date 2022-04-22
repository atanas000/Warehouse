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
using System.IO;

namespace Warehouse
{
    public partial class GettingStarted : Form
    {
        public GettingStarted()
        {
            InitializeComponent();
        }

        private void advancedWizard1_Cancel(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit without saving changes?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection($"server={srvBox.Text}; port={portBox.Text}; database={dbBox.Text}; uid={uidBox.Text}; pwd={pwdBox.Text}"))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    DialogResult dr = MessageBox.Show("Connection successful! Do you want to save the configuration?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        FillSettingsFile.server = srvBox.Text;
                        FillSettingsFile.port = portBox.Text;
                        FillSettingsFile.username = uidBox.Text;
                        FillSettingsFile.password = pwdBox.Text;
                        FillSettingsFile.db = dbBox.Text;
                    }
                }
            }
        }

        private void advancedWizard1_Finish(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Settings.txt", false))
            {
                sw.WriteLine(FillSettingsFile.server);
                sw.WriteLine(FillSettingsFile.port);
                sw.WriteLine(FillSettingsFile.username);
                sw.WriteLine(FillSettingsFile.password);
                sw.WriteLine(FillSettingsFile.db);
            }
            Application.Restart();
        }

        private void GettingStarted_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
