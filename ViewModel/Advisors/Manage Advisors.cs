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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MidProjectA.Forms.Advisors
{
    public partial class Manage_Advisors : Form
    {
        int gender;
        int id;
        public Manage_Advisors()
        {
            InitializeComponent();
            GenderToComboBox();
            DesignationToComboBox();
            btnAdd.Text = "Save";
            LoadData();
        }

        private void Manage_Advisors_Load(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("select p.id ,p.firstname,p.lastname,a.salary,l1.value as designation, p.contact,p.email,p.dateofbirth," +
                "l.value as Gender from Advisor a join person p on a.id=p.id join lookup l on p.gender=l.id join lookup l1 on" +
                " l1.id=a.designation WHERE p.contact NOT LIKE '~%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void icbtnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string FName = selectedRow.Cells["FirstName"].Value.ToString();
                string LName = selectedRow.Cells["LastName"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string dob = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string salary = selectedRow.Cells["Salary"].Value.ToString();
                string designation = selectedRow.Cells["Designation"].Value.ToString();
                textBoxFirName.Text = FName;
                textBoxLastName.Text = LName;
                textBoxContct.Text = contact;
                textBoxEmail.Text = email;
                comboBoxDesig.Text = designation;
                dateTimePicker1.Text = dob;
                comboBoxGnder.Text = gender;
                textBoxSalary.Text = salary;
                btnAdd.Text = "Update";
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a row before clicking the edit button.");
                dataGridView1.Visible = true;
            }
        }
        public int giveGender(string gen)
        {
            int g = -1;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Lookup WHERE Category=\'GENDER\' AND Value=@gender", con);
            cmd.Parameters.AddWithValue("@gender", gen);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                g = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return g;
        }
        public int giveDesignation(string desig)
        {
            int d = -1;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Lookup WHERE Category=\'DESIGNATION\' AND Value=@DESIGNATION", con);
            cmd.Parameters.AddWithValue("@DESIGNATION", desig);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                d = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return d;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int gender = giveGender(comboBoxGnder.Text);
            int desig = giveDesignation(comboBoxDesig.Text);

            if (Validation())
            {
                if (comboBoxDesig.Text != "")
                {
                    int salary = 0;
                    if (textBoxSalary.Text != "")
                    {
                        salary = int.Parse(textBoxSalary.Text);
                    }
                    if (btnAdd.Text== "Save")
                    {
                        try
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES (@FirstName,@LastName, @Contact,@Email,@DateOfBirth, @Gender); " +
                                "INSERT INTO Advisor(Id,Designation,Salary) VALUES ((SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName=@LastName AND Contact=@Contact AND Email=@Email AND DateOfBirth=@DateOfBirth AND Gender=@Gender) ,@Designation, @Salary);", con);
                            cmd.Parameters.AddWithValue("@FirstName", textBoxFirName.Text);
                            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                            cmd.Parameters.AddWithValue("@Contact", textBoxContct.Text);
                            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Designation", desig);
                            cmd.Parameters.AddWithValue("@Salary", salary);
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
                            SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName=@LastName, Contact=@Contact, Email=@Email, DateOfBirth=@DateOfBirth, Gender=@Gender WHERE Id=@Id; UPDATE Advisor SET Designation=@Designation, Salary=@Salary WHERE Id=@Id;", con);
                            cmd.Parameters.AddWithValue("@FirstName", textBoxFirName.Text);
                            cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                            cmd.Parameters.AddWithValue("@Contact", textBoxContct.Text);
                            cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Designation", desig);
                            cmd.Parameters.AddWithValue("@Salary", salary);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show("Record Updated");
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Please Select Designation of the Advisor", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {

            textBoxFirName.Clear();
            textBoxEmail.Clear();
            textBoxLastName.Clear();
            textBoxContct.Clear();
            textBoxSalary.Clear();
            comboBoxGnder.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void icBtnBack_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            dataGridView1.Visible = true;
        }
        ////////////////validations////
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
        private void DesignationToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Value from Lookup WHERE Category=\'DESIGNATION\'", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            comboBoxDesig.DataSource = dt.Tables[0].DefaultView;
            comboBoxDesig.DisplayMember = "Value";
        }
        private bool Validation()
        {
            bool isValid = true;
            if (!Validations.SalaryValidations(textBoxSalary.Text))
                {
                return false;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icbtnAdd_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBoxFirName.Text = "";
            textBoxLastName.Text = "";
            textBoxContct.Text = "";
            textBoxEmail.Text = "";
            comboBoxDesig.Text = "";
            dateTimePicker1.Text = "";
            comboBoxGnder.Text = "";
            textBoxSalary.Text = "";
            btnAdd.Text = "Save";
            tableLayoutPanel1.Visible = true;
        }

        private void iconBtnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string contact = selectedRow.Cells["Contact"].Value.ToString();

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE Person SET contact=concat('~',contact) WHERE id =@id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@contact", contact);
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
