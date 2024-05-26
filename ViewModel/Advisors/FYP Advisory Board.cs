using FontAwesome.Sharp;
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

namespace MidProjectA.ViewModel.Advisors
{
    public partial class FYP_Advisory_Board : Form
    {
        int projectId;
        public FYP_Advisory_Board()
        {
            InitializeComponent();
            LoadData();
            ProjectToComboBox();
            AdvisorToComboBox(comboBoxMad,"","");
            AdvisorToComboBox(comboBoxCoAv, "", "");
            AdvisorToComboBox(comboBoxIndAdv, "", "");
        }

        
        public void LoadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT PA.ProjectId, MAX(P.Title) Title, MAX(CASE WHEN PA.AdvisorRole = 11 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS MainAdvisor, MAX(CASE WHEN PA.AdvisorRole = 12 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS CoAdvisor, MAX(CASE WHEN PA.AdvisorRole = 14 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS IndustryAdvisor FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=A.Id GROUP BY PA.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
        }
        private void deleteRecord(int id)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor Where ProjectId=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Record Deleted!!!");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void AllProjectToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title from Project", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            comboBoxProj.DataSource = dt.Tables[0].DefaultView;
            comboBoxProj.DisplayMember = "Title";
        }
        private void AdvisorToComboBox(ComboBox cb, string adv1, string adv2)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT (P.FirstName+' '+P.LastName) AS Name FROM Advisor A JOIN Person P ON A.Id=P.Id WHERE (P.FirstName+' '+P.LastName)<>@name1 AND (P.FirstName+' '+P.LastName)<>@name2;", con);
                cmd.Parameters.AddWithValue("@name1", adv1);
                cmd.Parameters.AddWithValue("@name2", adv2);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                cb.DataSource = dataSet.Tables[0].DefaultView;
                cb.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
        private void ProjectToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title from Project P LEFT JOIN ProjectAdvisor PA ON P.Id=PA.ProjectId WHERE PA.AdvisorId IS NULL", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            comboBoxProj.DataSource = dt.Tables[0].DefaultView;
            comboBoxProj.DisplayMember = "Title";
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
        private string GetProjectTitle(int Id)
        {
            string title = "";
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Project WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    title = reader["Title"].ToString();
                }
                reader.Close();
                return title;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return "";
            }
        }
        private void AssignAdvisor(int role,int advId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@AdvisorId", advId);
                cmd.Parameters.AddWithValue("@AdvisorRole", role);
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void UpdateAdvisor( int role, int advId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole = @AdvisorRole WHERE ProjectId = @ProjectId AND AdvisorId = @AdvisorId", con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@AdvisorId", advId);
                cmd.Parameters.AddWithValue("@AdvisorRole", role);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void RemoveAdvisorToProject()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId=@projectId", con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private int AdvisorIdFromDataBase(string Name)
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT P.Id FROM Person P JOIN Advisor A ON A.Id=P.Id WHERE (P.FirstName+' '+P.LastName)=@Name", con);
            cmd.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }
        private int GetAdvisorRole(string role)
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Lookup WHERE Value='" + role + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FYP_Advisory_Board_Load(object sender, EventArgs e)
        {

        }

        private void icBtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

               int id = Convert.ToInt32(selectedRow.Cells["ProjectId"].Value);
                string adv1 = selectedRow.Cells["MainAdvisor"].ToString();
                string adv2 = selectedRow.Cells["CoAdvisor"].ToString();
                string adv3 = selectedRow.Cells["IndustryAdvisor"].ToString();
                AllProjectToComboBox();
                comboBoxProj.Text = GetProjectTitle(id);
                comboBoxProj.Enabled = false;
                AdvisorToComboBox(comboBoxMad, adv2, adv3);
                AdvisorToComboBox(comboBoxCoAv, adv1, adv3);
                AdvisorToComboBox(comboBoxIndAdv, adv1, adv2);
                comboBoxMad.Text = adv1;
                comboBoxCoAv.Text = adv2;
                comboBoxIndAdv.Text = adv3;
                iconButtonAdd.IconChar = IconChar.None;
                iconButtonAdd.Text = "Update";
                iconButtonAdd.Tag = "";
                dataGridView1.Visible = false;
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel2.Visible = true;
                tableLayoutPanel3.Visible=true;
                tableLayoutPanel4.Visible = true;

            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(comboBoxProj.Text==string.Empty)
            {
                System.Windows.MessageBox.Show("Select a project");
                return;
            }
            else if(comboBoxMad.Text==string.Empty|| comboBoxIndAdv.Text == string.Empty|| comboBoxCoAv.Text == string.Empty)
            {
                System.Windows.MessageBox.Show("Select an advisor");
                return;
            }
            if(iconButtonAdd.Tag.ToString()=="Add")
            {
                comboBoxProj.Enabled = true;
            GetProjectId(comboBoxProj.Text);
            RemoveAdvisorToProject();
            int AdvM = AdvisorIdFromDataBase(comboBoxMad.Text);
            int advCo=AdvisorIdFromDataBase(comboBoxCoAv.Text);
            int advInd = AdvisorIdFromDataBase(comboBoxIndAdv.Text);
            int madrole = GetAdvisorRole("Main Advisor");
            int coadrole = GetAdvisorRole("Co-Advisror");
            int inadrole = GetAdvisorRole("Industry Advisor");
            AssignAdvisor(madrole,AdvM);
            AssignAdvisor(coadrole, advCo);
            AssignAdvisor(inadrole, advInd);
            System.Windows.MessageBox.Show("Assigned Successfully");
            dataGridView1.Visible = true;
            tableLayoutPanel1.Visible = false;
            }
            else
            {
                GetProjectId(comboBoxProj.Text);
                int AdvM = AdvisorIdFromDataBase(comboBoxMad.Text);
                int advCo = AdvisorIdFromDataBase(comboBoxCoAv.Text);
                int advInd = AdvisorIdFromDataBase(comboBoxIndAdv.Text);
                int madrole = GetAdvisorRole("Main Advisor");
                int coadrole = GetAdvisorRole("Co-Advisror");
                int inadrole = GetAdvisorRole("Industry Advisor");
                UpdateAdvisor(madrole, AdvM);
                UpdateAdvisor(coadrole, advCo);
                UpdateAdvisor(inadrole, advInd);
                System.Windows.MessageBox.Show("Updated Successfully");
                dataGridView1.Visible = true;
                tableLayoutPanel1.Visible = false;
            }
        }

        private void icbtnAdd_Click(object sender, EventArgs e)
        {
            if (icbtnAdd.Tag.ToString() == "Assign Advisor")
            {
                dataGridView1.Visible = false;
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel2.Visible = true;
                tableLayoutPanel3.Visible = true;
                tableLayoutPanel4.Visible = true;
            }
        }

        private void comboBoxProj_DropDownClosed(object sender, EventArgs e)
        {
            GetProjectId(comboBoxProj.Text);
        }

        private void comboBoxMad_DropDownClosed(object sender, EventArgs e)
        {
            string ad1, ad2;
            ad1=comboBoxCoAv.Text;
            ad2=comboBoxIndAdv.Text;
            AdvisorToComboBox(comboBoxCoAv, comboBoxMad.Text, comboBoxIndAdv.Text);
            comboBoxCoAv.Text= ad1;
            comboBoxIndAdv.Text= ad2;
            AdvisorToComboBox(comboBoxIndAdv,comboBoxCoAv.Text,comboBoxMad.Text);
            comboBoxCoAv.Text = ad1;
            comboBoxIndAdv.Text=ad2;

        }

        private void comboBoxCoAv_DropDownClosed(object sender, EventArgs e)
        {
            string ad1, ad2;
            ad1 = comboBoxMad.Text;
            ad2 = comboBoxIndAdv.Text;
            AdvisorToComboBox(comboBoxMad, comboBoxCoAv.Text, comboBoxIndAdv.Text);
            comboBoxMad.Text = ad1;
            comboBoxIndAdv.Text = ad2;
            AdvisorToComboBox(comboBoxIndAdv, comboBoxCoAv.Text, comboBoxMad.Text);
            comboBoxMad.Text = ad1;
            comboBoxIndAdv.Text = ad2;

        }

        private void comboBoxIndAdv_DropDownClosed(object sender, EventArgs e)
        {
            string ad1, ad2;
            ad1 = comboBoxMad.Text;
            ad2 = comboBoxCoAv.Text;
            AdvisorToComboBox(comboBoxMad, comboBoxCoAv.Text, comboBoxIndAdv.Text);
            comboBoxMad.Text = ad1;
            comboBoxCoAv.Text = ad2;
            AdvisorToComboBox(comboBoxCoAv, comboBoxMad.Text, comboBoxIndAdv.Text);
            comboBoxMad.Text = ad1;
            comboBoxCoAv.Text = ad2;
        }

        private void icBtnDel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ProjectId"].Value);
                deleteRecord(id);
                LoadData();
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the delete button.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
