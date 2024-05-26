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

namespace MidProjectA.Forms.Projects
{
    public partial class Projects : Form
    {
        int id;
        public Projects()
        {
            InitializeComponent();
            butnAdd.Text = "Add";
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public void refresh()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand("select * from Student", con);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select p.id,p.title, p.description from project p", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.DataSource = dt;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butnAdd_Click(object sender, EventArgs e)
        {
        }
        private bool Validation()
        {
            string title = textBoxproTitle.Text;
            bool titleValid = false;
            string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz .";
            foreach (char n in title)
            {
                if (Alphabets.Contains(n.ToString()))
                {
                    titleValid = true;
                }
            }
            if (titleValid)
            {
                titleValid = !Validations.ValidationInDatabase("SELECT Title FROM Project WHERE Title='" + title + "' AND Id<>" + id);
                if (!titleValid)
                {
                    System.Windows.MessageBox.Show("There already exists one Project With the same name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Project Title must Contain Alphabets", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return titleValid;
        }

        private void icbtnEdit_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string Title = selectedRow.Cells["Title"].Value.ToString();
                string Description = selectedRow.Cells["Description"].Value.ToString();
                textBoxproTitle.Text = Title;
                textBoxDescription.Text = Description;
                textBoxproTitle.Enabled = false;
                butnAdd.Text = "Update";
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
                dataGridView1.Visible = true;
            }
        }

        private void icbtnAdd_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            butnAdd.Text = "Add";
            textBoxproTitle.Enabled = true;
            textBoxproTitle.Text = "";
            textBoxDescription.Text = "";
            tableLayoutPanel1.Visible = true;
        }

        private void butnAdd_Click_2(object sender, EventArgs e)
        {
            if (textBoxproTitle == null)
            {
                System.Windows.MessageBox.Show("Please add Title of project", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (textBoxDescription == null)
            {
                System.Windows.MessageBox.Show("Please add description of project", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Validation())
            {
                if (butnAdd.Text == "Add")
                {
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Project(Title,Description) values (@Title,@Description);", con);
                        cmd.Parameters.AddWithValue("@Title", textBoxproTitle.Text);
                        cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Successfully saved");
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
                        SqlCommand cmd = new SqlCommand("UPDATE Project SET title=@Title, description=@Description where id=@id;", con);
                        cmd.Parameters.AddWithValue("@Title", textBoxproTitle.Text);
                        cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        System.Windows.MessageBox.Show("Project Updated");
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
            textBoxproTitle.Enabled = false;
            textBoxDescription.Clear();
        }

        private void icBtnBack_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
