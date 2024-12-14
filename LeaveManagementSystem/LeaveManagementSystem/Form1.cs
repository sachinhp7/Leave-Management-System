using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.Text;

            string query = $"SELECT Role FROM Employees WHERE Name = '{username}' AND Password = '{password}'";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 1 && dt.Rows[0]["Role"].ToString() == role)
            {
                if (role == "Employee")
                {
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                }
                else if (role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
    }
}
