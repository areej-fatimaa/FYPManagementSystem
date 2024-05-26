using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MidProjectA.ViewModel.Evaluations
{
    public partial class Manage_Evaluation : Form
    {
        int id;
        public Manage_Evaluation()
        {
            InitializeComponent();
            LoadData();
            btnAdd.Text = "Add";
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select e.id ,e.Name, e.TotalMarks,e.TotalWeightage from evaluation e where e.name NOT LIKE '~%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;

        }
        private bool CalculateSumOfWeightage(int weightage)
        {
            int totalWeightage = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd= new SqlCommand("Select Sum(TotalWeightage) as Total from Evaluation where id!=@id",con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                totalWeightage = int.Parse(reader["Total"].ToString());
            }
            reader.Close();
            if(totalWeightage+weightage==100)
            {
                return false;
            }
            return true;
        }
        private bool Validation()
        {
            string title = txtBoxName.Text;
            bool Valid = false;
            if(title=="")
            {
                return false;
            }
            string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            foreach(char c in title)
            {
                if(Alphabets.Contains(c.ToString()))
                {
                    Valid = true;
                }
            }
            if(Valid)
            {
                if (btnAdd.Text == "Add")
                {
                    Valid = !Validations.ValidationInDatabase("Select name from evaluation where name='" + title + "' And id!=" + id);
                }
                if (!Valid)
                {
                    System.Windows.MessageBox.Show("There is already an evaluation with the same name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Title must contain an alphabet", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return Valid;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
        }

        private void icbtnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnAdd.Text = "Add";
            txtBoxName.Clear() ;
            textBoxTotalWeightage.Clear() ;
            textBoxTotalMarks.Clear();
            tableLayoutPanel1.Visible = true;
        }

        private void icBtnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                 id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string Name = selectedRow.Cells["Name"].Value.ToString();
                string TotalMarks = selectedRow.Cells["TotalMarks"].Value.ToString();
                string TotalWeightage = selectedRow.Cells["TotalWeightage"].Value.ToString();
                txtBoxName.Text = Name;
                textBoxTotalMarks.Text = TotalMarks;
                textBoxTotalWeightage.Text = TotalWeightage;
                btnAdd.Text = "Update";
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
                dataGridView1.Visible = true;
            }
        }

        private void Manage_Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void icBtnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE Evaluation SET Name=concat('~',name) where id=@id;", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    System.Windows.MessageBox.Show("Deleted");
                    LoadData();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                System.Windows.MessageBox.Show("Please select Name of Eevaluation", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (textBoxTotalMarks.Text == "")
            {
                System.Windows.MessageBox.Show("Please select Total Marks of the Evaluation", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (textBoxTotalWeightage.Text == "")
            {
                System.Windows.MessageBox.Show("Please select total weightage of the evaluation", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!CalculateSumOfWeightage(int.Parse(textBoxTotalWeightage.Text.ToString())))
            {
                System.Windows.MessageBox.Show("Total Weightage cannot be more than 100.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Validation())
            {
                if (btnAdd.Text == "Add")
                {
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation(Name,TotalMarks,TotalWeightage) values (@Name,@TotalMarks,@TotalWeightage);", con);
                        cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                        cmd.Parameters.AddWithValue("@TotalMarks", textBoxTotalMarks.Text);
                        cmd.Parameters.AddWithValue("@TotalWeightage", textBoxTotalWeightage.Text);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Successfully added");
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
                        SqlCommand cmd = new SqlCommand("UPDATE Evaluation SET Name=@Name, TotalMarks=@TotalMarks,TotalWeightage=@TotalWeightage where id=@id;", con);
                        cmd.Parameters.AddWithValue("@Name", txtBoxName.Text);
                        cmd.Parameters.AddWithValue("@TotalMarks", textBoxTotalMarks.Text);
                        cmd.Parameters.AddWithValue("@TotalWeightage", textBoxTotalWeightage.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Updated");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
            }
        }

        private void btnRevert_Click_1(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            textBoxTotalWeightage.Clear();
            textBoxTotalMarks.Clear();
        }

        private void iconButton12_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
