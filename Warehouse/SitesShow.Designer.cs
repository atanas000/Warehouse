namespace Warehouse
{
    partial class SitesShow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupsChBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.printBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupsPanel = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Site});
            this.dataGridView1.Location = new System.Drawing.Point(139, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(356, 353);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupsChBox
            // 
            this.groupsChBox.AutoSize = true;
            this.groupsChBox.Checked = true;
            this.groupsChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupsChBox.Location = new System.Drawing.Point(505, 268);
            this.groupsChBox.Name = "groupsChBox";
            this.groupsChBox.Size = new System.Drawing.Size(66, 19);
            this.groupsChBox.TabIndex = 46;
            this.groupsChBox.Text = "Groups";
            this.groupsChBox.UseVisualStyleBackColor = true;
            this.groupsChBox.CheckedChanged += new System.EventHandler(this.groupsChBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(505, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 76);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(6, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 18);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Code";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 18);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Site";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(505, 157);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(80, 23);
            this.printBtn.TabIndex = 45;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(505, 128);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 23);
            this.deleteBtn.TabIndex = 44;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(505, 99);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 23);
            this.editBtn.TabIndex = 43;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(505, 70);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(80, 23);
            this.newBtn.TabIndex = 42;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(505, 41);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(505, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 23);
            this.okBtn.TabIndex = 40;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // groupsPanel
            // 
            this.groupsPanel.BackColor = System.Drawing.Color.White;
            this.groupsPanel.Location = new System.Drawing.Point(10, 12);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.Size = new System.Drawing.Size(120, 352);
            this.groupsPanel.TabIndex = 48;
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
            // Site
            // 
            this.Site.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Site.DataPropertyName = "name";
            this.Site.HeaderText = "Site";
            this.Site.MinimumWidth = 250;
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            this.Site.Width = 250;
            // 
            // SitesShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupsChBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupsPanel);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SitesShow";
            this.Text = "Sites";
            this.Load += new System.EventHandler(this.SitesShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox groupsChBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel groupsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
    }
}