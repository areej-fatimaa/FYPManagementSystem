namespace MidProjectA.Forms.Groups
{
    partial class Groups
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
            this.icBtnBack = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icbtnAdd = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Desktoppanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icBtnEdit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.icBtnBack);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
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
            this.icBtnBack.Location = new System.Drawing.Point(738, 415);
            this.icBtnBack.Name = "icBtnBack";
            this.icBtnBack.Size = new System.Drawing.Size(62, 35);
            this.icBtnBack.TabIndex = 8;
            this.icBtnBack.UseVisualStyleBackColor = false;
            this.icBtnBack.Click += new System.EventHandler(this.icBtnBack_Click_1);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Location = new System.Drawing.Point(615, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(65, 34);
            this.panel4.TabIndex = 7;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(65, 34);
            this.iconButton2.TabIndex = 19;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
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
            this.icbtnAdd.Tag = "Add";
            this.icbtnAdd.UseVisualStyleBackColor = false;
            this.icbtnAdd.Click += new System.EventHandler(this.icbtnAdd_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.Desktoppanel);
            this.panelContainer.Controls.Add(this.dataGridView1);
            this.panelContainer.Location = new System.Drawing.Point(0, 34);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(797, 383);
            this.panelContainer.TabIndex = 6;
            // 
            // Desktoppanel
            // 
            this.Desktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktoppanel.Location = new System.Drawing.Point(0, 0);
            this.Desktoppanel.Name = "Desktoppanel";
            this.Desktoppanel.Size = new System.Drawing.Size(797, 383);
            this.Desktoppanel.TabIndex = 6;
            this.Desktoppanel.Visible = false;
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
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton icBtnEdit;
        private FontAwesome.Sharp.IconButton icbtnAdd;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton icBtnBack;
        private System.Windows.Forms.Panel Desktoppanel;
    }
}