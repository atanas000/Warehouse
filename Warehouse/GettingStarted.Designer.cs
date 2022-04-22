namespace Warehouse
{
    partial class GettingStarted
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GettingStarted));
            this.advancedWizard1 = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.advancedWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.advancedWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.srvBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbBox = new System.Windows.Forms.TextBox();
            this.uidBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.advancedWizard1.SuspendLayout();
            this.advancedWizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedWizard1
            // 
            this.advancedWizard1.BackButtonEnabled = true;
            this.advancedWizard1.BackButtonText = "< Back";
            this.advancedWizard1.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.advancedWizard1.ButtonsVisible = true;
            this.advancedWizard1.CancelButtonText = "&Cancel";
            this.advancedWizard1.Controls.Add(this.advancedWizardPage2);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage1);
            this.advancedWizard1.CurrentPageIsFinishPage = false;
            this.advancedWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizard1.FinishButton = true;
            this.advancedWizard1.FinishButtonEnabled = true;
            this.advancedWizard1.FinishButtonText = "&Finish";
            this.advancedWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.advancedWizard1.HelpButton = true;
            this.advancedWizard1.HelpButtonText = "&Help";
            this.advancedWizard1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizard1.Name = "advancedWizard1";
            this.advancedWizard1.NextButtonEnabled = false;
            this.advancedWizard1.NextButtonText = "Next >";
            this.advancedWizard1.ProcessKeys = false;
            this.advancedWizard1.Size = new System.Drawing.Size(586, 358);
            this.advancedWizard1.TabIndex = 0;
            this.advancedWizard1.TouchScreen = false;
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage1);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage2);
            this.advancedWizard1.Cancel += new System.EventHandler(this.advancedWizard1_Cancel);
            this.advancedWizard1.Finish += new System.EventHandler(this.advancedWizard1_Finish);
            // 
            // advancedWizardPage1
            // 
            this.advancedWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage1.Header = true;
            this.advancedWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage1.HeaderImage")));
            this.advancedWizardPage1.HeaderImageVisible = true;
            this.advancedWizardPage1.HeaderTitle = "Welcome to Warehouse v1.0.0";
            this.advancedWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage1.Name = "advancedWizardPage1";
            this.advancedWizardPage1.PreviousPage = 0;
            this.advancedWizardPage1.Size = new System.Drawing.Size(586, 318);
            this.advancedWizardPage1.SubTitle = "Your page description goes here";
            this.advancedWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage1.TabIndex = 1;
            // 
            // advancedWizardPage2
            // 
            this.advancedWizardPage2.Controls.Add(this.checkBtn);
            this.advancedWizardPage2.Controls.Add(this.portBox);
            this.advancedWizardPage2.Controls.Add(this.label5);
            this.advancedWizardPage2.Controls.Add(this.label4);
            this.advancedWizardPage2.Controls.Add(this.label3);
            this.advancedWizardPage2.Controls.Add(this.label1);
            this.advancedWizardPage2.Controls.Add(this.pwdBox);
            this.advancedWizardPage2.Controls.Add(this.uidBox);
            this.advancedWizardPage2.Controls.Add(this.dbBox);
            this.advancedWizardPage2.Controls.Add(this.srvBox);
            this.advancedWizardPage2.Controls.Add(this.label2);
            this.advancedWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage2.Header = true;
            this.advancedWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage2.HeaderImage")));
            this.advancedWizardPage2.HeaderImageVisible = true;
            this.advancedWizardPage2.HeaderTitle = "1. Database configuration";
            this.advancedWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage2.Name = "advancedWizardPage2";
            this.advancedWizardPage2.PreviousPage = 0;
            this.advancedWizardPage2.Size = new System.Drawing.Size(586, 318);
            this.advancedWizardPage2.SubTitle = "Specify your database information";
            this.advancedWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage2.TabIndex = 2;
            // 
            // srvBox
            // 
            this.srvBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srvBox.Location = new System.Drawing.Point(99, 96);
            this.srvBox.Name = "srvBox";
            this.srvBox.Size = new System.Drawing.Size(194, 23);
            this.srvBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbBox
            // 
            this.dbBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbBox.Location = new System.Drawing.Point(99, 125);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(194, 23);
            this.dbBox.TabIndex = 4;
            // 
            // uidBox
            // 
            this.uidBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uidBox.Location = new System.Drawing.Point(99, 154);
            this.uidBox.Name = "uidBox";
            this.uidBox.Size = new System.Drawing.Size(194, 23);
            this.uidBox.TabIndex = 5;
            // 
            // pwdBox
            // 
            this.pwdBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pwdBox.Location = new System.Drawing.Point(99, 183);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(194, 23);
            this.pwdBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Database:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(306, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portBox.Location = new System.Drawing.Point(345, 96);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(56, 23);
            this.portBox.TabIndex = 11;
            this.portBox.Text = "3306";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(315, 183);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(86, 23);
            this.checkBtn.TabIndex = 15;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 358);
            this.Controls.Add(this.advancedWizard1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GettingStarted";
            this.Text = "Getting Started";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GettingStarted_FormClosing);
            this.advancedWizard1.ResumeLayout(false);
            this.advancedWizardPage2.ResumeLayout(false);
            this.advancedWizardPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard advancedWizard1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage2;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage1;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox uidBox;
        private System.Windows.Forms.TextBox dbBox;
        private System.Windows.Forms.TextBox srvBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkBtn;
    }
}