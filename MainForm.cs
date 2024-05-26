using MidProjectA.Forms.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MidProjectA
{
    public partial class MainForm : Form
    {
        public  Form activateForm;
        public MainForm()
        {
            InitializeComponent();

            CollapseMenu();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildform(new Forms.Projects.Projects(), sender);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            openChildform(new ViewModel.Advisors.FYP_Advisory_Board(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
        }
        public void openChildform(Form childForm,object btnSender)
        {
            if(activateForm!=null)
            {
                activateForm.Close();
            }
            activateForm = childForm;childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            this.paneldesktop.Dock = DockStyle.Fill;
            childForm.Dock = DockStyle.Fill; this.Desktoppanel.Controls.Add(childForm);
            this.paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            textBox1.Text = childForm.Text;
        }
        public void CloseChildForm()
        {
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm = null; 
                textBox1.Text = ""; 
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if(this.panelMenu.Width>200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   "+menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           // dataGridView1.Visible = true;
            openChildform(new Forms.Student.EditStudents(), sender);
           // LoadData();
        }

        private void Desktoppanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
  

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildform(new Forms.Advisors.Manage_Advisors(), sender);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openChildform(new ViewModel.Evaluations.Manage_Evaluation(), sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openChildform(new ViewModel.Evaluations.Mark_Evaluation(), sender);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildform(new Forms.Groups.Groups(), sender);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            openChildform(new ViewModel.Reports.Generate_Reports(), sender);
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
