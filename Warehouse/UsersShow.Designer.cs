namespace Warehouse
{
    partial class UsersShow
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
            this.groupsPanel = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupsChBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.name,
            this.role});
            this.dataGridView1.Location = new System.Drawing.Point(142, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(356, 353);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupsPanel
            // 
            this.groupsPanel.BackColor = System.Drawing.Color.White;
            this.groupsPanel.Location = new System.Drawing.Point(13, 13);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.Size = new System.Drawing.Size(120, 352);
            this.groupsPanel.TabIndex = 12;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(505, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(505, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(505, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(505, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupsChBox
            // 
            this.groupsChBox.AutoSize = true;
            this.groupsChBox.Checked = true;
            this.groupsChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupsChBox.Location = new System.Drawing.Point(505, 293);
            this.groupsChBox.Name = "groupsChBox";
            this.groupsChBox.Size = new System.Drawing.Size(66, 19);
            this.groupsChBox.TabIndex = 10;
            this.groupsChBox.Text = "Groups";
            this.groupsChBox.UseVisualStyleBackColor = true;
            this.groupsChBox.CheckedChanged += new System.EventHandler(this.groupsChBox_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Code";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 19);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Role";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(505, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 99);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 100;
            this.role.Name = "role";
            this.role.ReadOnly = true;
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
            // UsersShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupsChBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupsPanel);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UsersShow";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel groupsPanel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox groupsChBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}