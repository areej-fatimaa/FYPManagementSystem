using MidProjectA.Forms.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MidProjectA.Forms.Groups
{
    public partial class Groups : Form
    {
        int groupId, projectId;
        public Form activateForm;
        public Groups()
        {
            InitializeComponent();
            LoadData();
        }

        public void openChildform(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm; childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; this.Desktoppanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        public void CloseChildForm()
        {
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm = null;
            }
        }

        private void Groups_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT('G-',G.Id) AS GroupId,P.Id AS ProjectId,P.Title,COUNT(GS.StudentId) AS GStudent,(SELECT FORMAT(G.Created_On, 'dd-MM-yyyy')) AS Created_On FROM [Group] AS G LEFT JOIN GroupProject AS GP ON G.Id=GP.GroupId LEFT JOIN GroupStudent AS GS ON GS.GroupId=G.Id LEFT JOIN Project AS P ON GP.ProjectId=P.Id WHERE GS.Status=3 GROUP BY G.Id,P.Id,P.Title,G.Created_On", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void icbtnAdd_Click(object sender, EventArgs e)
        {
            if (icbtnAdd.Tag.ToString() == "Add")
            {
                try
                {
                    int id = 0;
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Group](Created_On) VALUES(@date); SELECT Id FROM [Group] ORDER BY Id Desc", con);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = int.Parse(reader["Id"].ToString());
                    }
                    reader.Close();
                    System.Windows.MessageBox.Show("Group G-" + id + " Created Successfully");
                     Desktoppanel.Visible = true;
                    openChildform(new ViewModel.Groups.AddGroup(id), sender);
                    dataGridView1.Visible = false;
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            LoadData();
        }
    
        
       
       
        

       
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string GroupId = selectedRow.Cells["GroupId"].Value.ToString();
                string projectId = selectedRow.Cells["ProjectId"].Value.ToString();
                string[] GId = GroupId.Split('-');
                groupId = int.Parse(GId[1]);
                 dataGridView1.Visible=false;
                 Desktoppanel.Visible = true;
                 openChildform(new ViewModel.Groups.ViewDetails(groupId,projectId), sender);

            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
        }

        private void icBtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string GroupId = selectedRow.Cells["GroupId"].Value.ToString();
                string projectId = selectedRow.Cells["ProjectId"].Value.ToString();
                string[] GId = GroupId.Split('-');
                groupId = int.Parse(GId[1]);
                dataGridView1.Visible = false;
                Desktoppanel.Visible = true;
                openChildform(new ViewModel.Groups.AddGroup(groupId, projectId), sender);

            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
        }

        private void icBtnBack_Click_1(object sender, EventArgs e)
        {
            CloseChildForm();
            Desktoppanel.Visible= false;
            dataGridView1.Visible = true;
        }
    }
}
