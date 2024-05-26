namespace MidProjectA.ViewModel.Groups
{
    partial class ViewDetails
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
            this.groupNameDisplayTextBlock = new System.Windows.Forms.TextBox();
            this.textBoxPNameDetails = new System.Windows.Forms.TextBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNameDisplayTextBlock
            // 
            this.groupNameDisplayTextBlock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupNameDisplayTextBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupNameDisplayTextBlock.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupNameDisplayTextBlock.Enabled = false;
            this.groupNameDisplayTextBlock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameDisplayTextBlock.ForeColor = System.Drawing.Color.White;
            this.groupNameDisplayTextBlock.Location = new System.Drawing.Point(33, 11);
            this.groupNameDisplayTextBlock.Multiline = true;
            this.groupNameDisplayTextBlock.Name = "groupNameDisplayTextBlock";
            this.groupNameDisplayTextBlock.Size = new System.Drawing.Size(210, 148);
            this.groupNameDisplayTextBlock.TabIndex = 21;
            this.groupNameDisplayTextBlock.Text = "   Group\r\n   ";
            // 
            // textBoxPNameDetails
            // 
            this.textBoxPNameDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxPNameDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPNameDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPNameDetails.Enabled = false;
            this.textBoxPNameDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPNameDetails.ForeColor = System.Drawing.Color.White;
            this.textBoxPNameDetails.Location = new System.Drawing.Point(33, 308);
            this.textBoxPNameDetails.Multiline = true;
            this.textBoxPNameDetails.Name = "textBoxPNameDetails";
            this.textBoxPNameDetails.Size = new System.Drawing.Size(210, 121);
            this.textBoxPNameDetails.TabIndex = 20;
            this.textBoxPNameDetails.Text = "Ptoject Title:\r\n      \r\n        ";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToAddRows = false;
            this.dataGridViewDetails.AllowUserToDeleteRows = false;
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.GridColor = System.Drawing.Color.White;
            this.dataGridViewDetails.Location = new System.Drawing.Point(249, 11);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.ReadOnly = true;
            this.dataGridViewDetails.Size = new System.Drawing.Size(276, 291);
            this.dataGridViewDetails.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.239547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.76045F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDetails, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupNameDisplayTextBlock, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPNameDetails, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.895136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.758686F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 23;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewDetails";
            this.Text = "ViewDetails";
            this.Load += new System.EventHandler(this.ViewDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox groupNameDisplayTextBlock;
        private System.Windows.Forms.TextBox textBoxPNameDetails;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}