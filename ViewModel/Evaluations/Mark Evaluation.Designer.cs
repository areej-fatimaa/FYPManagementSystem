namespace MidProjectA.ViewModel.Evaluations
{
    partial class Mark_Evaluation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTMarks = new System.Windows.Forms.TextBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.textBoxObtMarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coboxGroup = new System.Windows.Forms.ComboBox();
            this.coboxEvaluation = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icBtnEdit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
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
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTMarks, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRevert, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.iconButton12, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxObtMarks, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.coboxGroup, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.coboxEvaluation, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.333989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.973F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.7154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 383);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evaluation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Marks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTMarks
            // 
            this.textBoxTMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTMarks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTMarks.Location = new System.Drawing.Point(259, 141);
            this.textBoxTMarks.Multiline = true;
            this.textBoxTMarks.Name = "textBoxTMarks";
            this.textBoxTMarks.Size = new System.Drawing.Size(360, 45);
            this.textBoxTMarks.TabIndex = 9;
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevert.ForeColor = System.Drawing.Color.White;
            this.btnRevert.Location = new System.Drawing.Point(538, 244);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(81, 48);
            this.btnRevert.TabIndex = 15;
            this.btnRevert.Text = "Clear";
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(625, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iconButton12
            // 
            this.iconButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton12.FlatAppearance.BorderSize = 0;
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.iconButton12.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // textBoxObtMarks
            // 
            this.textBoxObtMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxObtMarks.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObtMarks.Location = new System.Drawing.Point(259, 192);
            this.textBoxObtMarks.Multiline = true;
            this.textBoxObtMarks.Name = "textBoxObtMarks";
            this.textBoxObtMarks.Size = new System.Drawing.Size(360, 46);
            this.textBoxObtMarks.TabIndex = 17;
            this.textBoxObtMarks.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 52);
            this.label4.TabIndex = 16;
            this.label4.Text = "Obtained Marks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coboxGroup
            // 
            this.coboxGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coboxGroup.FormattingEnabled = true;
            this.coboxGroup.Location = new System.Drawing.Point(259, 30);
            this.coboxGroup.Name = "coboxGroup";
            this.coboxGroup.Size = new System.Drawing.Size(360, 21);
            this.coboxGroup.TabIndex = 18;
            this.coboxGroup.DropDownClosed += new System.EventHandler(this.coboxGroup_DropDownClosed);
            // 
            // coboxEvaluation
            // 
            this.coboxEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coboxEvaluation.FormattingEnabled = true;
            this.coboxEvaluation.Location = new System.Drawing.Point(259, 85);
            this.coboxEvaluation.Name = "coboxEvaluation";
            this.coboxEvaluation.Size = new System.Drawing.Size(360, 21);
            this.coboxEvaluation.TabIndex = 19;
            this.coboxEvaluation.DropDownClosed += new System.EventHandler(this.coboxEvaluation_DropDownClosed);
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
            // Mark_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Mark_Evaluation";
            this.Text = "Mark_Evaluation";
            this.Load += new System.EventHandler(this.Mark_Evaluation_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icbtnAdd;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTMarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton icBtnEdit;
        private System.Windows.Forms.TextBox textBoxObtMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox coboxGroup;
        private System.Windows.Forms.ComboBox coboxEvaluation;
    }
}