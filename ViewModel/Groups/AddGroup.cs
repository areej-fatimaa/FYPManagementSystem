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

namespace MidProjectA.ViewModel.Groups
{
    public partial class AddGroup : Form
    {
        int groupId,projectId;
        public AddGroup()
        {
            InitializeComponent();
        }
        public AddGroup(int groupid)
        {
            InitializeComponent();
            groupId = groupid;
            labelProject.Text = labelProject.Text + groupId;
            ProjectToComboBox();
            GetStudentsOfGroup(dataGridViewGrp);
            StudentToComboBox();
        }
        public AddGroup(int groupid,string projectid)
        {
            InitializeComponent();
            this.groupId = groupid;
            try
            {
                this.projectId = int.Parse(projectid);
                GetCurrentProjectAssigned();
            }
            catch
            {
                textBoxPTitle.Text = "Not Assigned";
            }
            labelProject.Text = "G-" + groupId;
            ProjectToComboBox();
            GetStudentsOfGroup(dataGridViewGrp);
            StudentToComboBox();
            iconBtnInactive.Visible = true;
        }
        private int StudentIdFromDataBase()
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Student AS S WHERE S.RegistrationNo=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", comboBoxStudent.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }
        private void StudentToComboBox()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo FROM Student s LEFT JOIN (SELECT * FROM GroupStudent GS1 WHERE GS1.AssignmentDate = ( SELECT MAX(GS2.AssignmentDate) FROM GroupStudent GS2 WHERE GS2.StudentId = GS1.StudentId)) recent ON s.Id = recent.StudentID WHERE recent.Status = 4 OR recent.GroupID IS NULL", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                comboBoxStudent.DataSource = dataSet.Tables[0].DefaultView;
                comboBoxStudent.DisplayMember = "RegistrationNo";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
        private void GetStudentsOfGroup(DataGridView dg)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name,S.Id ,S.RegistrationNo ,L.Value AS Status  FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId AND GS.Status=@Status", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@Status", 3);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt.DefaultView;
        }

        private void icBtnSelectProject_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void GetCurrentProjectAssigned()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Project AS P,GroupProject AS GP WHERE  P.Id=GP.ProjectId AND GP.GroupId=@GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxPTitle.Text = "Project Title\n          "+reader["Title"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        private void ProjectToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title from Project WHERE Id<>'" + projectId + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            comboBoxProject.DataSource = dt.Tables[0].DefaultView;
            comboBoxProject.DisplayMember = "Title";
        }

        private void textBoxPTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelProject_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {

        }

      
        private void icBtnSelectProject_Click_1(object sender, EventArgs e)
        {
            if (comboBoxProject.Text == string.Empty)
            {
                System.Windows.MessageBox.Show("You need To First Select a project to assign to this group", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GetProjectId(comboBoxProject.Text);
            if (textBoxPTitle.Text == "Not Assigned")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject VALUES (@ProjectId, @GroupId, @Date)", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE GroupProject SET ProjectId=@ProjectId,AssignmentDate=@Date WHERE GroupId=@GroupId", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                    return;
                }
            }
            GetCurrentProjectAssigned();
            ProjectToComboBox();
            comboBoxProject.Text = string.Empty;
            System.Windows.MessageBox.Show("Project Assigned Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        
    }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            int stuId;
            if (comboBoxStudent.Text != string.Empty)
            {
                stuId = StudentIdFromDataBase();
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId=@StudentId AND GroupId=@GroupId; INSERT INTO GroupStudent VALUES (@GroupId, @StudentId,@Status,@Date)", con);
                    cmd.Parameters.AddWithValue("@StudentId", stuId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.ExecuteNonQuery();
                    comboBoxStudent.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);

                }
            }
            StudentToComboBox();
            GetStudentsOfGroup(dataGridViewGrp);
        }

        private void iconBtnInactive_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewGrp.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewGrp.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewGrp.Rows[selectedRowIndex];
                string regNo = selectedRow.Cells["RegistrationNo"].Value.ToString();

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd1 = new SqlCommand("Update Groupstudent set status =4 where studentid=(select id from student where registrationno=@RegistrationNo)", con);
                    cmd1.Parameters.AddWithValue("@RegistrationNo", regNo);
                    cmd1.ExecuteNonQuery();
                    GetStudentsOfGroup(dataGridViewGrp);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
        }

        private void textBoxPTitle_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GetProjectId(string title)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Project WHERE Title=@title", con);
                cmd.Parameters.AddWithValue("@title", title);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    projectId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
