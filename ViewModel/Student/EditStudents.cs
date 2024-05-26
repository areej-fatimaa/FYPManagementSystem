using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MidProjectA.Forms.Student
{
    public partial class EditStudents : Form
    {
        int id;
        int gender = 1;
        public EditStudents()
        {
            InitializeComponent();
            GenderToComboBox();
            btnAdd.Text = "Add";
            LoadData();
        }
        private void GenderToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Value from Lookup WHERE Category='GENDER'", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            comboBoxGnder.Items.Clear();
            comboBoxGnder.DataSource = dt.Tables[0];
            comboBoxGnder.DisplayMember = "Value";
        }
        private void EditStudents_Load(object sender, EventArgs e)
        {

        }
        private bool Validation()
        {
            bool isValid = true;
            if (btnAdd.Text=="Add")
            {
                if (!Validations.RegistrationNoValidations(textBoxRegNo.Text, id))
                {
                    return false;
                }
            }
            if (!Validations.FirstNameValidations(textBoxFirName.Text))
            {
                return false;
            }
            if (!Validations.LastNameValidations(textBoxLastName.Text))
            {
                return false;
            }
            if (!Validations.ContactValidations(textBoxContct.Text))
            {
                return false;
            }
            if (!Validations.EmailValidations(textBoxEmail.Text))
            {
                return false;
            }
            if (!Validations.DoBValidations(dateTimePicker1.Text, 1995, 2003))
            {
                return false;
            }
            if (comboBoxGnder.Text == "")
            {
                System.Windows.MessageBox.Show("Select a Gender First", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return isValid;
        }
        public int returnSelectedGender(string gen)
        {
            int g = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Lookup WHERE Category='GENDER' AND Value=@gender", con);
            cmd.Parameters.AddWithValue("@gender", gen);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                g = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return g;
        }
       
        private void iconButton10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string FName = selectedRow.Cells["FirstName"].Value.ToString();
                string LName = selectedRow.Cells["LastName"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string regno = selectedRow.Cells["RegistrationNo"].Value.ToString();
                string dob = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                textBoxFirName.Text = FName;
                textBoxLastName.Text = LName;
                textBoxContct.Text = contact;
                textBoxEmail.Text = email;
                textBoxRegNo.Text = regno;
                dateTimePicker1.Text = dob;
                comboBoxGnder.Text = gender;
                textBoxRegNo.Enabled = false;
                btnAdd.Text = "Update";

            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
            }
            tableLayoutPanel1.Visible = true;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
        }
        ////////////////////Data//////////////
        public void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select s.RegistrationNo, p.firstname,p.lastname,p.contact,p.email,p.dateofbirth," +
                "l.value as Gender from Student s join person p on s.id=p.id join lookup l on p.gender=l.id WHERE s.RegistrationNo NOT LIKE '%~%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void icbtnAdd_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBoxFirName.Text="";
            textBoxLastName.Text = "";
            textBoxContct.Text = "";
            textBoxEmail.Text = "";
            textBoxRegNo.Text = "";
            dateTimePicker1.Text = "";
            comboBoxGnder.Text = "";
            textBoxRegNo.Enabled = true;
            btnAdd.Text = "Add";
            tableLayoutPanel1.Visible = true;
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                gender = returnSelectedGender(comboBoxGnder.Text);
                if (btnAdd.Text.ToString() == "Add")
                {
                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES (@FirstName,@LastName, @Contact,@Email,@DateOfBirth, @Gender); insert into Student(Id,RegistrationNo) VALUES ((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName=@LastName AND Contact=@Contact AND Email=@Email AND DateOfBirth=@DateOfBirth AND Gender=@Gender) ,@RegistrationNo);", con);
                        cmd.Parameters.AddWithValue("@FirstName", textBoxFirName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@Contact", textBoxContct.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@RegistrationNo", textBoxRegNo.Text);
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
                        string textBoxText = textBoxRegNo.Text;

                        // Display the text in a MessageBox
                        System.Windows.MessageBox.Show(textBoxText);
                        SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE id = (SELECT id FROM Student WHERE RegistrationNo = @RegistrationNo)", con);
                        cmd.Parameters.AddWithValue("@FirstName", textBoxFirName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@Contact", textBoxContct.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@RegistrationNo", textBoxRegNo.Text);
                        cmd.Parameters.AddWithValue("@Id", id);
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

        private void btnRevert_Click_1(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                textBoxRegNo.Clear();
            }

            textBoxFirName.Clear();
            textBoxEmail.Clear();
            textBoxLastName.Clear();
            textBoxContct.Clear();
            comboBoxGnder.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string regNo = selectedRow.Cells["RegistrationNo"].Value.ToString();

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE Student SET RegistrationNo=concat('~',RegistrationNo) WHERE id = (SELECT id FROM Student WHERE RegistrationNo = @RegistrationNo)", con);
                    SqlCommand cmd1 = new SqlCommand("Update Groupstudent set status =4 where studentid=id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@RegistrationNo", regNo);
                    cmd.ExecuteNonQuery();
                    System.Windows.MessageBox.Show("Record Deleted");
                    LoadData();
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
    }
}
