namespace MidProjectA.Forms.Projects
{
    partial class Projects
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.icbtnAdd = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icbtnEdit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxproTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.butnAdd = new System.Windows.Forms.Button();
            this.icBtnBack = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.icbtnAdd);
            this.panel4.Location = new System.Drawing.Point(681, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(61, 36);
            this.panel4.TabIndex = 23;
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
            this.icbtnAdd.Size = new System.Drawing.Size(61, 36);
            this.icbtnAdd.TabIndex = 22;
            this.icbtnAdd.UseVisualStyleBackColor = false;
            this.icbtnAdd.Click += new System.EventHandler(this.icbtnAdd_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.icbtnEdit);
            this.panel3.Location = new System.Drawing.Point(739, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 36);
            this.panel3.TabIndex = 22;
            // 
            // icbtnEdit
            // 
            this.icbtnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icbtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icbtnEdit.FlatAppearance.BorderSize = 0;
            this.icbtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnEdit.ForeColor = System.Drawing.Color.White;
            this.icbtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icbtnEdit.IconColor = System.Drawing.Color.White;
            this.icbtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnEdit.IconSize = 30;
            this.icbtnEdit.Location = new System.Drawing.Point(0, 0);
            this.icbtnEdit.Name = "icbtnEdit";
            this.icbtnEdit.Size = new System.Drawing.Size(61, 36);
            this.icbtnEdit.TabIndex = 21;
            this.icbtnEdit.UseVisualStyleBackColor = false;
            this.icbtnEdit.Click += new System.EventHandler(this.icbtnEdit_Click_2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 408);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 408);
            this.dataGridView1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxproTitle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRevert, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.butnAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.icBtnBack, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.111111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 408);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 147);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxproTitle
            // 
            this.textBoxproTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxproTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproTitle.Location = new System.Drawing.Point(227, 39);
            this.textBoxproTitle.Multiline = true;
            this.textBoxproTitle.Name = "textBoxproTitle";
            this.textBoxproTitle.Size = new System.Drawing.Size(349, 36);
            this.textBoxproTitle.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(227, 93);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(349, 141);
            this.textBoxDescription.TabIndex = 10;
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRevert.FlatAppearance.BorderSize = 0;
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevert.ForeColor = System.Drawing.Color.White;
            this.btnRevert.Location = new System.Drawing.Point(495, 240);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(81, 40);
            this.btnRevert.TabIndex = 20;
            this.btnRevert.Text = "Clear";
            this.btnRevert.UseVisualStyleBackColor = false;
            // 
            // butnAdd
            // 
            this.butnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.butnAdd.FlatAppearance.BorderSize = 0;
            this.butnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnAdd.ForeColor = System.Drawing.Color.White;
            this.butnAdd.Location = new System.Drawing.Point(582, 240);
            this.butnAdd.Name = "butnAdd";
            this.butnAdd.Size = new System.Drawing.Size(104, 40);
            this.butnAdd.TabIndex = 21;
            this.butnAdd.Text = "Add";
            this.butnAdd.UseVisualStyleBackColor = false;
            // 
            // icBtnBack
            // 
            this.icBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.icBtnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icBtnBack.FlatAppearance.BorderSize = 0;
            this.icBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnBack.ForeColor = System.Drawing.Color.White;
            this.icBtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.icBtnBack.IconColor = System.Drawing.Color.White;
            this.icBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnBack.IconSize = 30;
            this.icBtnBack.Location = new System.Drawing.Point(707, 372);
            this.icBtnBack.Name = "icBtnBack";
            this.icBtnBack.Size = new System.Drawing.Size(72, 33);
            this.icBtnBack.TabIndex = 22;
            this.icBtnBack.UseVisualStyleBackColor = false;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Projects";
            this.Text = "Projects";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton icbtnAdd;
        private FontAwesome.Sharp.IconButton icbtnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxproTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button butnAdd;
        private FontAwesome.Sharp.IconButton icBtnBack;
    }
}