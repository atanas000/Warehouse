namespace Warehouse
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partnerBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measure = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sumL = new System.Windows.Forms.Label();
            this.vatL = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            this.partnerShow = new System.Windows.Forms.Button();
            this.locationShow = new System.Windows.Forms.Button();
            this.userShow = new System.Windows.Forms.Button();
            this.optBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.commentBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Partner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partnerBox
            // 
            this.partnerBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partnerBox.Location = new System.Drawing.Point(110, 62);
            this.partnerBox.Name = "partnerBox";
            this.partnerBox.Size = new System.Drawing.Size(221, 23);
            this.partnerBox.TabIndex = 1;
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationBox.Location = new System.Drawing.Point(110, 93);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(221, 23);
            this.locationBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Site";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBox.Location = new System.Drawing.Point(110, 124);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(221, 23);
            this.userBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "User";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.stockName,
            this.measure,
            this.quantity,
            this.price1,
            this.sum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 327);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // num
            // 
            this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.num.DefaultCellStyle = dataGridViewCellStyle1;
            this.num.HeaderText = "№";
            this.num.Name = "num";
            this.num.Width = 46;
            // 
            // stockName
            // 
            this.stockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockName.HeaderText = "Stock";
            this.stockName.MinimumWidth = 460;
            this.stockName.Name = "stockName";
            this.stockName.Width = 460;
            // 
            // measure
            // 
            this.measure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.measure.DefaultCellStyle = dataGridViewCellStyle2;
            this.measure.HeaderText = "Measure";
            this.measure.MinimumWidth = 100;
            this.measure.Name = "measure";
            this.measure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 80;
            // 
            // price1
            // 
            this.price1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.price1.DefaultCellStyle = dataGridViewCellStyle4;
            this.price1.HeaderText = "Price for 1 piece";
            this.price1.MinimumWidth = 100;
            this.price1.Name = "price1";
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.sum.DefaultCellStyle = dataGridViewCellStyle5;
            this.sum.HeaderText = "Sum";
            this.sum.MinimumWidth = 100;
            this.sum.Name = "sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(774, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sum:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(780, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "VAT:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(774, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumL
            // 
            this.sumL.AutoSize = true;
            this.sumL.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumL.Location = new System.Drawing.Point(824, 65);
            this.sumL.Name = "sumL";
            this.sumL.Size = new System.Drawing.Size(31, 19);
            this.sumL.TabIndex = 11;
            this.sumL.Text = "NA";
            this.sumL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vatL
            // 
            this.vatL.AutoSize = true;
            this.vatL.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vatL.Location = new System.Drawing.Point(824, 96);
            this.vatL.Name = "vatL";
            this.vatL.Size = new System.Drawing.Size(31, 19);
            this.vatL.TabIndex = 12;
            this.vatL.Text = "NA";
            this.vatL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalL
            // 
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalL.Location = new System.Drawing.Point(824, 127);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(31, 19);
            this.totalL.TabIndex = 13;
            this.totalL.Text = "NA";
            this.totalL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partnerShow
            // 
            this.partnerShow.Font = new System.Drawing.Font("SF Pro Rounded", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partnerShow.Location = new System.Drawing.Point(304, 64);
            this.partnerShow.Name = "partnerShow";
            this.partnerShow.Size = new System.Drawing.Size(25, 18);
            this.partnerShow.TabIndex = 2;
            this.partnerShow.Text = "...";
            this.partnerShow.UseVisualStyleBackColor = true;
            this.partnerShow.Click += new System.EventHandler(this.partnerShow_Click);
            // 
            // locationShow
            // 
            this.locationShow.Font = new System.Drawing.Font("SF Pro Rounded", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationShow.Location = new System.Drawing.Point(304, 95);
            this.locationShow.Name = "locationShow";
            this.locationShow.Size = new System.Drawing.Size(25, 18);
            this.locationShow.TabIndex = 4;
            this.locationShow.Text = "...";
            this.locationShow.UseVisualStyleBackColor = true;
            this.locationShow.Click += new System.EventHandler(this.locationShow_Click);
            // 
            // userShow
            // 
            this.userShow.Font = new System.Drawing.Font("SF Pro Rounded", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userShow.Location = new System.Drawing.Point(304, 126);
            this.userShow.Name = "userShow";
            this.userShow.Size = new System.Drawing.Size(25, 18);
            this.userShow.TabIndex = 6;
            this.userShow.Text = "...";
            this.userShow.UseVisualStyleBackColor = true;
            this.userShow.Click += new System.EventHandler(this.userShow_Click);
            // 
            // optBtn
            // 
            this.optBtn.Location = new System.Drawing.Point(12, 534);
            this.optBtn.Name = "optBtn";
            this.optBtn.Size = new System.Drawing.Size(86, 23);
            this.optBtn.TabIndex = 8;
            this.optBtn.Text = "Options";
            this.optBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(855, 534);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(763, 534);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // commentBtn
            // 
            this.commentBtn.Location = new System.Drawing.Point(671, 534);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(86, 23);
            this.commentBtn.TabIndex = 12;
            this.commentBtn.Text = "Comment";
            this.commentBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(379, 534);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(86, 23);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(187, 534);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(186, 23);
            this.searchBox.TabIndex = 9;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 569);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.optBtn);
            this.Controls.Add(this.userShow);
            this.Controls.Add(this.locationShow);
            this.Controls.Add(this.partnerShow);
            this.Controls.Add(this.totalL);
            this.Controls.Add(this.vatL);
            this.Controls.Add(this.sumL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.partnerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partnerBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sumL;
        private System.Windows.Forms.Label vatL;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Button partnerShow;
        private System.Windows.Forms.Button locationShow;
        private System.Windows.Forms.Button userShow;
        private System.Windows.Forms.Button optBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockName;
        private System.Windows.Forms.DataGridViewComboBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}