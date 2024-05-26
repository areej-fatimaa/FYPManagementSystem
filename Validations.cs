using MidProjectA.Forms.Student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MidProjectA
{
     class Validations
    {
        public static bool ValidationInDatabase(string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
        public static bool RegistrationNoValidations(string reg, int id)
        {
            if (reg == "")
            {
                MessageBox.Show("Registration Number cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!(reg.Length > 8))
            {
                MessageBox.Show("Registration Number is not up to the required Format i.e., xxxx-CS-xxx", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            string yearStr = reg.Substring(0, 4);
            int year;
            if (!int.TryParse(yearStr, out year) || !(year > 2000 && year < DateTime.Now.Year))
            {
                MessageBox.Show("Year should be between 2000 and " + DateTime.Now.Year, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            string departmentStr = reg.Substring(4, 4);
            if (!(departmentStr == "-CS-"))
            {
                MessageBox.Show("Registration Number is not up to the required Format i.e., xxxx-CS-xxx", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            int roll;
            string rollNoStr = reg.Substring(8, reg.Length - 8);
            if (!int.TryParse(rollNoStr, out roll))
            {
                MessageBox.Show("Roll Number must be an integer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (ValidationInDatabase("SELECT RegistrationNo FROM Student WHERE RegistrationNo='" + reg + "' AND Id<>'" + id + "'"))
            {
                MessageBox.Show("Registration Number is already taken up by another student", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public static bool FirstNameValidations(string name)
        {
            if (name == "" || name == " ")
            {
                MessageBox.Show("First Name cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            bool nameValid = true;
            string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
            foreach (char n in name)
            {
                if (!Alphabets.Contains(n.ToString()))
                {
                    MessageBox.Show("First Name can only be Alphabets", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    nameValid = false;
                }
            }
            return nameValid;
        }

        public static bool LastNameValidations(string name)
        {
            if (name == " ")
            {
                MessageBox.Show("Last Name cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            bool nameValid = true;
            string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
            foreach (char n in name)
            {
                if (!Alphabets.Contains(n.ToString()))
                {
                    MessageBox.Show("Last Name can only be Alphabets", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    nameValid = false;
                }
            }
            return nameValid;
        }
        public static bool ContactValidations(string contact)
        {
            if (contact == "")
            {
                return true;
            }
            string numb = contact.Substring(4, contact.Length - 4);
            string numbers = "0123456789";
            if (contact[0] == '+' && contact[1] == '9' && contact[2] == '2' && contact[3] == '-' && contact[4] == '3' && contact.Length == 14)
            {
                foreach (char n in numb)
                {
                    if (!numbers.Contains(n.ToString()))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Contact Format should be +92-3xxxxxxxxx", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public static bool EmailValidations(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            MessageBox.Show("Provided email is not valid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
        public static bool DoBValidations(string dob, int minYear, int maxYear)
        {
            if (dob == "")
            {
                MessageBox.Show(" You Haven't Selected Date of Birth Please select it first ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            bool isValid = true;

            if (DateTime.Parse(dob).Year > maxYear)
            {
                MessageBox.Show("Date Of Birth's Year cannot be more than " + maxYear, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (DateTime.Parse(dob).Year < minYear)
            {
                MessageBox.Show("Date Of Birth's Year cannot be less than " + minYear, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return isValid;
        }
        public static bool SalaryValidations(string salary)
        {
            if (salary == "")
            {
                return true;
            }
            string numbers = "0123456789";
            bool isValid = true;
            foreach (char n in salary)
            {
                if (!numbers.Contains(n.ToString()))
                {
                    MessageBox.Show("Salary could only be integers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            return isValid;
        }
    }
}
