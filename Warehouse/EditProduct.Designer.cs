namespace Warehouse
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.basicInfo = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.namePrint = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.additionalInfo = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.VATGroupBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.measureBox = new System.Windows.Forms.ComboBox();
            this.prices = new System.Windows.Forms.TabPage();
            this.wholesalePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.retailPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groups = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.basicInfo.SuspendLayout();
            this.additionalInfo.SuspendLayout();
            this.prices.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(143, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(229, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.basicInfo);
            this.tabControl1.Controls.Add(this.additionalInfo);
            this.tabControl1.Controls.Add(this.prices);
            this.tabControl1.Controls.Add(this.groups);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 323);
            this.tabControl1.TabIndex = 18;
            // 
            // basicInfo
            // 
            this.basicInfo.Controls.Add(this.label9);
            this.basicInfo.Controls.Add(this.nameBox);
            this.basicInfo.Controls.Add(this.codeBox);
            this.basicInfo.Controls.Add(this.label2);
            this.basicInfo.Controls.Add(this.label3);
            this.basicInfo.Controls.Add(this.label8);
            this.basicInfo.Controls.Add(this.namePrint);
            this.basicInfo.Controls.Add(this.statusBox);
            this.basicInfo.Controls.Add(this.barcodeBox);
            this.basicInfo.Controls.Add(this.label7);
            this.basicInfo.Controls.Add(this.descBox);
            this.basicInfo.Controls.Add(this.label1);
            this.basicInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.basicInfo.Location = new System.Drawing.Point(4, 24);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.basicInfo.Size = new System.Drawing.Size(426, 295);
            this.basicInfo.TabIndex = 0;
            this.basicInfo.Text = "Basic information";
            this.basicInfo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(61, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(110, 89);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(296, 23);
            this.nameBox.TabIndex = 2;
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.Location = new System.Drawing.Point(110, 60);
            this.codeBox.Name = "codeBox";
            this.codeBox.ReadOnly = true;
            this.codeBox.Size = new System.Drawing.Size(97, 23);
            this.codeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 63);
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
            this.label3.Location = new System.Drawing.Point(15, 121);
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
            this.label8.Location = new System.Drawing.Point(58, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 65;
            this.label8.Text = "Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // namePrint
            // 
            this.namePrint.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePrint.Location = new System.Drawing.Point(110, 118);
            this.namePrint.Name = "namePrint";
            this.namePrint.Size = new System.Drawing.Size(296, 23);
            this.namePrint.TabIndex = 3;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.statusBox.Location = new System.Drawing.Point(110, 205);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(296, 23);
            this.statusBox.TabIndex = 9;
            // 
            // barcodeBox
            // 
            this.barcodeBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeBox.Location = new System.Drawing.Point(110, 147);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(296, 23);
            this.barcodeBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Description:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descBox.Location = new System.Drawing.Point(110, 176);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(296, 23);
            this.descBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Barcode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // additionalInfo
            // 
            this.additionalInfo.Controls.Add(this.label4);
            this.additionalInfo.Controls.Add(this.VATGroupBox);
            this.additionalInfo.Controls.Add(this.label13);
            this.additionalInfo.Controls.Add(this.typeBox);
            this.additionalInfo.Controls.Add(this.label5);
            this.additionalInfo.Controls.Add(this.measureBox);
            this.additionalInfo.Location = new System.Drawing.Point(4, 24);
            this.additionalInfo.Name = "additionalInfo";
            this.additionalInfo.Size = new System.Drawing.Size(426, 295);
            this.additionalInfo.TabIndex = 2;
            this.additionalInfo.Text = "Additional info";
            this.additionalInfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "VAT Group:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VATGroupBox
            // 
            this.VATGroupBox.FormattingEnabled = true;
            this.VATGroupBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.VATGroupBox.Location = new System.Drawing.Point(102, 162);
            this.VATGroupBox.Name = "VATGroupBox";
            this.VATGroupBox.Size = new System.Drawing.Size(296, 23);
            this.VATGroupBox.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(60, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 83;
            this.label13.Text = "Type:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.typeBox.Location = new System.Drawing.Point(102, 133);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(296, 23);
            this.typeBox.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Measure:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // measureBox
            // 
            this.measureBox.FormattingEnabled = true;
            this.measureBox.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.measureBox.Location = new System.Drawing.Point(102, 104);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(296, 23);
            this.measureBox.TabIndex = 80;
            // 
            // prices
            // 
            this.prices.Controls.Add(this.wholesalePrice);
            this.prices.Controls.Add(this.label6);
            this.prices.Controls.Add(this.retailPrice);
            this.prices.Controls.Add(this.label10);
            this.prices.Location = new System.Drawing.Point(4, 24);
            this.prices.Name = "prices";
            this.prices.Size = new System.Drawing.Size(426, 295);
            this.prices.TabIndex = 3;
            this.prices.Text = "Prices";
            this.prices.UseVisualStyleBackColor = true;
            // 
            // wholesalePrice
            // 
            this.wholesalePrice.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wholesalePrice.Location = new System.Drawing.Point(174, 130);
            this.wholesalePrice.Name = "wholesalePrice";
            this.wholesalePrice.Size = new System.Drawing.Size(164, 23);
            this.wholesalePrice.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(95, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "Retail price:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // retailPrice
            // 
            this.retailPrice.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retailPrice.Location = new System.Drawing.Point(174, 159);
            this.retailPrice.Name = "retailPrice";
            this.retailPrice.Size = new System.Drawing.Size(164, 23);
            this.retailPrice.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(68, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Wholesale price:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groups
            // 
            this.groups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groups.Location = new System.Drawing.Point(4, 24);
            this.groups.Name = "groups";
            this.groups.Padding = new System.Windows.Forms.Padding(3);
            this.groups.Size = new System.Drawing.Size(426, 295);
            this.groups.TabIndex = 1;
            this.groups.Text = "Groups";
            this.groups.UseVisualStyleBackColor = true;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditProduct";
            this.Text = "Edit product";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.basicInfo.ResumeLayout(false);
            this.basicInfo.PerformLayout();
            this.additionalInfo.ResumeLayout(false);
            this.additionalInfo.PerformLayout();
            this.prices.ResumeLayout(false);
            this.prices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage basicInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namePrint;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage additionalInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VATGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox measureBox;
        private System.Windows.Forms.TabPage prices;
        private System.Windows.Forms.TextBox wholesalePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox retailPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage groups;
    }
}