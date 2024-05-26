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
    public partial class ViewDetails : Form
    {
        int groupId;int projectID;
        public ViewDetails()
        {
            InitializeComponent();
           
        }
        public ViewDetails(int groupid,string projectid)
        {
            InitializeComponent();
            this.groupId = groupid;
            try
            {
                this.projectID = int.Parse(projectid);
                GetCurrentProjectAssigned();
            }
            catch
            {
                textBoxPNameDetails.Text = "Not Assigned";
            }
            groupNameDisplayTextBlock.Text = "   Group \n      G-" + groupId;
            GetAllStudentsOfGroup();
        }
        private void GetAllStudentsOfGroup()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name,S.Id ,S.RegistrationNo ,L.Value AS Status  FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
             dataGridViewDetails.DataSource = dt.DefaultView;
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
                    textBoxPNameDetails.Text = reader["Title"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        
        private void ViewDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPNameDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
