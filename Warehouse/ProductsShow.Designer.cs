namespace Warehouse
{
    partial class ProductsShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsShow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsChBox = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.measure,
            this.deliveryPrice,
            this.sellingPrice});
            this.dataGridView1.Location = new System.Drawing.Point(138, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 353);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.code.DataPropertyName = "id";
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 62;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 62;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 150;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // measure
            // 
            this.measure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.measure.DataPropertyName = "measure";
            this.measure.HeaderText = "Measure";
            this.measure.MinimumWidth = 100;
            this.measure.Name = "measure";
            this.measure.ReadOnly = true;
            // 
            // deliveryPrice
            // 
            this.deliveryPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliveryPrice.DataPropertyName = "wholesalePrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.deliveryPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.deliveryPrice.HeaderText = "Wholesale price";
            this.deliveryPrice.MinimumWidth = 112;
            this.deliveryPrice.Name = "deliveryPrice";
            this.deliveryPrice.ReadOnly = true;
            this.deliveryPrice.Width = 112;
            // 
            // sellingPrice
            // 
            this.sellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sellingPrice.DataPropertyName = "retailPrice";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.sellingPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellingPrice.HeaderText = "Retail price";
            this.sellingPrice.MinimumWidth = 112;
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            this.sellingPrice.Width = 112;
            // 
            // groupsChBox
            // 
            this.groupsChBox.AutoSize = true;
            this.groupsChBox.Checked = true;
            this.groupsChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupsChBox.Location = new System.Drawing.Point(725, 261);
            this.groupsChBox.Name = "groupsChBox";
            this.groupsChBox.Size = new System.Drawing.Size(66, 19);
            this.groupsChBox.TabIndex = 36;
            this.groupsChBox.Text = "Groups";
            this.groupsChBox.UseVisualStyleBackColor = true;
            this.groupsChBox.CheckedChanged += new System.EventHandler(this.groupsChBox_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(725, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(725, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 23);
            this.okBtn.TabIndex = 30;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // groupsPanel
            // 
            this.groupsPanel.BackColor = System.Drawing.Color.White;
            this.groupsPanel.Location = new System.Drawing.Point(11, 12);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.Size = new System.Drawing.Size(120, 352);
            this.groupsPanel.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sort";
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Code",
            "Name",
            "Measure",
            "Delivery price",
            "Selling price"});
            this.sortBox.Location = new System.Drawing.Point(725, 223);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(80, 22);
            this.sortBox.TabIndex = 40;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // ProductsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 377);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupsChBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupsPanel);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductsShow";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox groupsChBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel groupsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
    }
}