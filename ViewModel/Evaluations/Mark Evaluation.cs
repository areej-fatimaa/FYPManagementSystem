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

namespace MidProjectA.ViewModel.Evaluations
{
    public partial class Mark_Evaluation : Form
    {
        int groupid, evaluationid;
        public Mark_Evaluation()
        {
            InitializeComponent();
            GroupToComboBox();
            EvaluationToCombo();
            btnAdd.Text = "Add";
            LoadData();
        }
        private void GroupToComboBox()
        {
            var con=Configuration.getInstance().getConnection();
            SqlCommand cmd= new SqlCommand("Select concat('G-',G.id) as groupid from [Group] as g left join groupproject as GP on g.id=GP.ProjectId left join \r\nGroupStudent as SG on sg.GroupId=g.id left join project as p on gp.projectid=p.id where SG.Status=3 group by g.id,p.id,p.title,g.created_on;", con);
            SqlDataAdapter d= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            d.Fill(ds);
            coboxGroup.Items.Clear();
            coboxGroup.DataSource = ds.Tables[0];
            coboxGroup.DisplayMember = "GroupId";
        }
        private void EvaluationToCombo()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select e.name from evaluation e except select e.name from evaluation e join groupevaluation GE on GE.evaluationid=e.id join [group] g on g.id=GE.groupid where g.id='"+groupid+"'", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            d.Fill(ds);
            coboxEvaluation.Items.Clear();
            coboxEvaluation.DataSource = ds.Tables[0];
            coboxEvaluation.DisplayMember = "Name";
        }
        private void GetEvaluationid(string name)
        {
            var con=Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,TotalMarks from Evaluation where name=@name", con);
            cmd.Parameters.AddWithValue("name", name);
            SqlDataReader reader=cmd.ExecuteReader();
            if(reader.Read())
            {
                evaluationid = int.Parse(reader["id"].ToString());
                textBoxTMarks.Text = reader["totalMarks"].ToString();
            }
            reader.Close();
        }
        private bool ObtMarksValidations(string marks)
        {
            string num = "0123456789";
            foreach(char n in marks)
            {
                if(!num.Contains(n.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select concat('G-',GroupId) as GroupId,Name,Evaluationid,TotalMarks,ObtainedMarks,Evaluationdate " +
                "from groupevaluation gv join evaluation e on gv.evaluationid=e.id;", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icbtnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            coboxEvaluation.Text = "";
            coboxGroup.Text = "";
            textBoxObtMarks.Text = "";
            textBoxTMarks.Text = "";
            btnAdd.Text = "Add";
            tableLayoutPanel1.Visible = true;
        }

        private void icBtnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string GroupID = selectedRow.Cells["GroupId"].Value.ToString();
                string EvaluationTitle = selectedRow.Cells["Name"].Value.ToString();
                string TotalMarks = selectedRow.Cells["TotalMarks"].Value.ToString();
                string ObtainedMarks = selectedRow.Cells["ObtainedMarks"].Value.ToString();
                coboxGroup.Text = GroupID;
                coboxEvaluation.Text = EvaluationTitle;
                textBoxTMarks.Text = TotalMarks;
                textBoxObtMarks.Text = ObtainedMarks;
                coboxEvaluation.Enabled=false;
                coboxGroup.Enabled=false;
                textBoxTMarks.Enabled = false;
                btnAdd.Text = "Update";

            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
            tableLayoutPanel1.Visible = true;
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
            textBoxTMarks.Clear();
            coboxEvaluation.Text = "";
            coboxGroup.Text = "";
            }
                textBoxObtMarks.Clear();

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void Mark_Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void coboxEvaluation_DropDownClosed(object sender, EventArgs e)
        {
            if(sender.Equals(coboxEvaluation))
            {
                GetEvaluationid(coboxEvaluation.Text);
            }
            else
            {
                if(coboxGroup.Text!=string.Empty)
                {
                    string []GroupId=coboxGroup.Text.Split('-');
                    this.groupid = int.Parse(GroupId[1]);
                    EvaluationToCombo();
                }
            }
        }

        private void coboxGroup_DropDownClosed(object sender, EventArgs e)
        {
            if (coboxGroup.Text != string.Empty)
            {
                string[] GroupId = coboxGroup.Text.Split('-');
                this.groupid = int.Parse(GroupId[1]);
            }
        }

        private void icBtnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(coboxGroup.Text==string.Empty)
            {
                System.Windows.MessageBox.Show("Please select a group to evaluate", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(coboxEvaluation.Text==string.Empty)
            {
                System.Windows.MessageBox.Show("Please select evaluation title to evaluate", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(textBoxObtMarks.Text==string.Empty)
            {
                System.Windows.MessageBox.Show("Group Cannot have null marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (int.Parse(textBoxObtMarks.Text) > int.Parse(textBoxTMarks.Text))
            {
                System.Windows.MessageBox.Show("Obtained marks cannot be greater then total marks", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(ObtMarksValidations(textBoxObtMarks.Text))
            {
                if(btnAdd.Text=="Add")
                {
                    try
                    {
                        System.Windows.MessageBox.Show(groupid.ToString());
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSert into Groupevaluation values (@GroupId,@EvaluationID,@ObtainedMarks,@Date)", con);
                        if (coboxGroup.Text != string.Empty)
                        {
                            string[] GroupId = coboxGroup.Text.Split('-');
                            this.groupid = int.Parse(GroupId[1]);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Please select a group to mark evaluation");
                        }
                        cmd.Parameters.AddWithValue("@GroupID",groupid);
                        cmd.Parameters.AddWithValue("@EvaluationID", evaluationid);
                        cmd.Parameters.AddWithValue("@ObtainedMarks", int.Parse(textBoxObtMarks.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Successfully saved");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("UPDATE GroupEvaluation set ObtainedMarks=@ObtainedMarks,EvaluationDate=@Date where GroupId=@GroupID and EvaluationID=@EvaluationId;", con);
                        if (coboxGroup.Text != string.Empty)
                        {
                            string[] GroupId = coboxGroup.Text.Split('-');
                            this.groupid = int.Parse(GroupId[1]);
                        }
                        cmd.Parameters.AddWithValue("@GroupID", groupid);
                        GetEvaluationid(coboxEvaluation.Text);
                        cmd.Parameters.AddWithValue("@EvaluationID", evaluationid);
                        cmd.Parameters.AddWithValue("@ObtainedMarks", int.Parse(textBoxObtMarks.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Record Updated");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }

            }
        }
    }
}
