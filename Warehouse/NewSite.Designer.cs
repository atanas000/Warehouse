namespace Warehouse
{
    partial class NewSite
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.namePrintBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.priceGroupBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(143, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(229, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 323);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.priceGroupBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.codeBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.namePrintBox);
            this.tabPage1.Controls.Add(this.statusBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(59, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(108, 106);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(289, 23);
            this.nameBox.TabIndex = 2;
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.Location = new System.Drawing.Point(108, 77);
            this.codeBox.Name = "codeBox";
            this.codeBox.ReadOnly = true;
            this.codeBox.Size = new System.Drawing.Size(97, 23);
            this.codeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name for print:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(56, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 65;
            this.label8.Text = "Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // namePrintBox
            // 
            this.namePrintBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePrintBox.Location = new System.Drawing.Point(108, 135);
            this.namePrintBox.Name = "namePrintBox";
            this.namePrintBox.Size = new System.Drawing.Size(289, 23);
            this.namePrintBox.TabIndex = 3;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.statusBox.Location = new System.Drawing.Point(108, 193);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(289, 23);
            this.statusBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Price group:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.FormattingEnabled = true;
            this.priceGroupBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.priceGroupBox.Location = new System.Drawing.Point(108, 164);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(183, 23);
            this.priceGroupBox.TabIndex = 68;
            // 
            // NewSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewSite";
            this.Text = "New site";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namePrintBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox priceGroupBox;
    }
}