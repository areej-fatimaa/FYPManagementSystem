namespace MidProjectA.ViewModel.Evaluations
{
    partial class Manage_Evaluation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icbtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTotalMarks = new System.Windows.Forms.TextBox();
            this.textBoxTotalWeightage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.icBtnDel = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icBtnEdit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.icbtnAdd);
            this.panel2.Location = new System.Drawing.Point(733, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 34);
            this.panel2.TabIndex = 3;
            // 
            // icbtnAdd
            // 
            this.icbtnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icbtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icbtnAdd.FlatAppearance.BorderSize = 0;
            this.icbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnAdd.ForeColor = System.Drawing.Color.White;
            this.icbtnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.icbtnAdd.IconColor = System.Drawing.Color.White;
            this.icbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnAdd.IconSize = 30;
            this.icbtnAdd.Location = new System.Drawing.Point(0, 0);
            this.icbtnAdd.Name = "icbtnAdd";
            this.icbtnAdd.Size = new System.Drawing.Size(67, 34);
            this.icbtnAdd.TabIndex = 19;
            this.icbtnAdd.UseVisualStyleBackColor = false;
            this.icbtnAdd.Click += new System.EventHandler(this.icbtnAdd_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.tableLayoutPanel1);
            this.panelContainer.Controls.Add(this.dataGridView1);
            this.panelContainer.Location = new System.Drawing.Point(0, 34);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(797, 383);
            this.panelContainer.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.432611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80089F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.515611F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconButton12, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTotalMarks, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTotalWeightage, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRevert, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.700688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.3941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.72165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.41151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.13036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 383);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton12
            // 
            this.iconButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton12.ForeColor = System.Drawing.Color.White;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton12.IconColor = System.Drawing.Color.White;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 30;
            this.iconButton12.Location = new System.Drawing.Point(747, 339);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Size = new System.Drawing.Size(47, 41);
            this.iconButton12.TabIndex = 7;
            this.iconButton12.UseVisualStyleBackColor = false;
            this.iconButton12.Click += new System.EventHandler(this.iconButton12_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Marks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Weightage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(259, 32);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(360, 52);
            this.txtBoxName.TabIndex = 7;
            // 
            // textBoxTotalMarks
            // 
            this.textBoxTotalMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalMarks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMarks.Location = new System.Drawing.Point(259, 90);
            this.textBoxTotalMarks.Multiline = true;
            this.textBoxTotalMarks.Name = "textBoxTotalMarks";
            this.textBoxTotalMarks.Size = new System.Drawing.Size(360, 54);
            this.textBoxTotalMarks.TabIndex = 8;
            // 
            // textBoxTotalWeightage
            // 
            this.textBoxTotalWeightage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalWeightage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalWeightage.Location = new System.Drawing.Point(259, 150);
            this.textBoxTotalWeightage.Multiline = true;
            this.textBoxTotalWeightage.Name = "textBoxTotalWeightage";
            this.textBoxTotalWeightage.Size = new System.Drawing.Size(360, 49);
            this.textBoxTotalWeightage.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(625, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevert.ForeColor = System.Drawing.Color.White;
            this.btnRevert.Location = new System.Drawing.Point(538, 205);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(81, 50);
            this.btnRevert.TabIndex = 15;
            this.btnRevert.Text = "Clear";
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 383);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.icBtnDel);
            this.panel4.Location = new System.Drawing.Point(625, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 34);
            this.panel4.TabIndex = 5;
            // 
            // icBtnDel
            // 
            this.icBtnDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icBtnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icBtnDel.FlatAppearance.BorderSize = 0;
            this.icBtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnDel.ForeColor = System.Drawing.Color.White;
            this.icBtnDel.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.icBtnDel.IconColor = System.Drawing.Color.White;
            this.icBtnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnDel.IconSize = 30;
            this.icBtnDel.Location = new System.Drawing.Point(0, 0);
            this.icBtnDel.Name = "icBtnDel";
            this.icBtnDel.Size = new System.Drawing.Size(54, 34);
            this.icBtnDel.TabIndex = 20;
            this.icBtnDel.UseVisualStyleBackColor = false;
            this.icBtnDel.Click += new System.EventHandler(this.icBtnDel_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.icBtnEdit);
            this.panel3.Location = new System.Drawing.Point(675, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 34);
            this.panel3.TabIndex = 4;
            // 
            // icBtnEdit
            // 
            this.icBtnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icBtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icBtnEdit.FlatAppearance.BorderSize = 0;
            this.icBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnEdit.ForeColor = System.Drawing.Color.White;
            this.icBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icBtnEdit.IconColor = System.Drawing.Color.White;
            this.icBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnEdit.IconSize = 30;
            this.icBtnEdit.Location = new System.Drawing.Point(0, 0);
            this.icBtnEdit.Name = "icBtnEdit";
            this.icBtnEdit.Size = new System.Drawing.Size(65, 34);
            this.icBtnEdit.TabIndex = 18;
            this.icBtnEdit.UseVisualStyleBackColor = false;
            this.icBtnEdit.Click += new System.EventHandler(this.icBtnEdit_Click);
            // 
            // Manage_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Evaluation";
            this.Text = "Manage_Evaluation";
            this.Load += new System.EventHandler(this.Manage_Evaluation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icbtnAdd;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton icBtnDel;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton icBtnEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox textBoxTotalMarks;
        private System.Windows.Forms.TextBox textBoxTotalWeightage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRevert;
    }
}