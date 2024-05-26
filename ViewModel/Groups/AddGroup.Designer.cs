namespace MidProjectA.ViewModel.Groups
{
    partial class AddGroup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProject = new System.Windows.Forms.Label();
            this.textBoxPTitle = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.icBtnSelectProject = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.iconBtnInactive = new FontAwesome.Sharp.IconButton();
            this.dataGridViewGrp = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelProject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProject, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStudent, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.175277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.758763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.758763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.087403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.509884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.52965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.40582F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 450);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProject.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProject.Location = new System.Drawing.Point(3, 27);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(238, 71);
            this.labelProject.TabIndex = 0;
            this.labelProject.Text = "Group\r\n G-";
            this.labelProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPTitle
            // 
            this.textBoxPTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxPTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPTitle.Enabled = false;
            this.textBoxPTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxPTitle.Location = new System.Drawing.Point(3, 108);
            this.textBoxPTitle.Multiline = true;
            this.textBoxPTitle.Name = "textBoxPTitle";
            this.textBoxPTitle.Size = new System.Drawing.Size(238, 73);
            this.textBoxPTitle.TabIndex = 17;
            this.textBoxPTitle.Text = "Ptoject Title:\r\n      \r\n        NotAssigned";
            this.textBoxPTitle.TextChanged += new System.EventHandler(this.textBoxPTitle_TextChanged_1);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.BackColor = System.Drawing.Color.White;
            this.comboBoxProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(3, 239);
            this.comboBoxProject.MaxDropDownItems = 100;
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(238, 21);
            this.comboBoxProject.TabIndex = 19;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.BackColor = System.Drawing.Color.White;
            this.comboBoxStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(3, 332);
            this.comboBoxStudent.MaxDropDownItems = 100;
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(238, 21);
            this.comboBoxStudent.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.9916F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0084F));
            this.tableLayoutPanel2.Controls.Add(this.icBtnSelectProject, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 194);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 39);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // icBtnSelectProject
            // 
            this.icBtnSelectProject.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icBtnSelectProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icBtnSelectProject.FlatAppearance.BorderSize = 0;
            this.icBtnSelectProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnSelectProject.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnSelectProject.ForeColor = System.Drawing.Color.White;
            this.icBtnSelectProject.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.icBtnSelectProject.IconColor = System.Drawing.Color.White;
            this.icBtnSelectProject.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.icBtnSelectProject.IconSize = 30;
            this.icBtnSelectProject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icBtnSelectProject.Location = new System.Drawing.Point(191, 3);
            this.icBtnSelectProject.Name = "icBtnSelectProject";
            this.icBtnSelectProject.Size = new System.Drawing.Size(44, 33);
            this.icBtnSelectProject.TabIndex = 20;
            this.icBtnSelectProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnSelectProject.UseVisualStyleBackColor = false;
            this.icBtnSelectProject.Click += new System.EventHandler(this.icBtnSelectProject_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Select Project";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.9916F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0084F));
            this.tableLayoutPanel3.Controls.Add(this.iconButton1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 286);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 40);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(191, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 34);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "Select Student";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // iconBtnInactive
            // 
            this.iconBtnInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnInactive.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnInactive.FlatAppearance.BorderSize = 0;
            this.iconBtnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnInactive.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnInactive.ForeColor = System.Drawing.Color.White;
            this.iconBtnInactive.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnInactive.IconColor = System.Drawing.Color.White;
            this.iconBtnInactive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnInactive.IconSize = 30;
            this.iconBtnInactive.Location = new System.Drawing.Point(723, 402);
            this.iconBtnInactive.Name = "iconBtnInactive";
            this.iconBtnInactive.Size = new System.Drawing.Size(77, 36);
            this.iconBtnInactive.TabIndex = 29;
            this.iconBtnInactive.Text = "InActive";
            this.iconBtnInactive.UseVisualStyleBackColor = false;
            this.iconBtnInactive.Visible = false;
            this.iconBtnInactive.Click += new System.EventHandler(this.iconBtnInactive_Click_1);
            // 
            // dataGridViewGrp
            // 
            this.dataGridViewGrp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGrp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGrp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewGrp.GridColor = System.Drawing.Color.White;
            this.dataGridViewGrp.Location = new System.Drawing.Point(244, 0);
            this.dataGridViewGrp.Name = "dataGridViewGrp";
            this.dataGridViewGrp.Size = new System.Drawing.Size(556, 450);
            this.dataGridViewGrp.TabIndex = 18;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconBtnInactive);
            this.Controls.Add(this.dataGridViewGrp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconBtnInactive;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.TextBox textBoxPTitle;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton icBtnSelectProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewGrp;
    }
}