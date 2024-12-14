using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnApproveLeave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLeaveID.Text))
            {
                MessageBox.Show("Please enter a valid Leave ID.");
                return;
            }

            // Ensure LeaveID is a valid integer
            if (!int.TryParse(txtLeaveID.Text, out int leaveID))
            {
                MessageBox.Show("Leave ID must be a valid number.");
                return;
            }

            string query = $"UPDATE LeaveApplications SET Status = 'Approved' WHERE LeaveID = {leaveID}";

            try
            {
                int result = DatabaseHelper.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Leave approved successfully.");
                }
                else
                {
                    MessageBox.Show("Leave approval failed. Check the Leave ID.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
        }

        private void btnRejectLeave_Click(object sender, EventArgs e)
        {
            string leaveID = txtLeaveID.Text;
            string query = $"UPDATE LeaveApplications SET Status = 'Rejected' WHERE LeaveID = {leaveID}";
            int result = DatabaseHelper.ExecuteNonQuery(query);

            MessageBox.Show(result > 0 ? "Leave rejected." : "Action failed.");
        }

        private void btnViewAllLeaves_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LeaveApplications";
            dgvAllLeaves.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text;
            string password = txtEmployeePassword.Text;
            string role = cmbEmployeeRole.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = $"INSERT INTO Employees (Name, Password, Role) VALUES ('{name}', '{password}', '{role}')";
            int result = DatabaseHelper.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("Employee added successfully.");
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Failed to add employee.");
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            string name = txtEmployeeName.Text;
            string password = txtEmployeePassword.Text;
            string role = cmbEmployeeRole.Text;

            if (string.IsNullOrWhiteSpace(employeeID) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = $"UPDATE Employees SET Name = '{name}', Password = '{password}', Role = '{role}' WHERE EmployeeID = {employeeID}";
            int result = DatabaseHelper.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("Employee updated successfully.");
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Failed to update employee.");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;

            if (string.IsNullOrWhiteSpace(employeeID))
            {
                MessageBox.Show("Please specify an Employee ID.");
                return;
            }

            string query = $"DELETE FROM Employees WHERE EmployeeID = {employeeID}";
            int result = DatabaseHelper.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("Employee deleted successfully.");
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Failed to delete employee.");
            }
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            string query = "SELECT EmployeeID, Name, Role FROM Employees";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvEmployees.DataSource = dt;
        }
    }
}
