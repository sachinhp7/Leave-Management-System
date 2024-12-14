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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            string leaveType = cmbLeaveType.Text;
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");

            string query = $"INSERT INTO LeaveApplications (EmployeeID, LeaveType, StartDate, EndDate, Status) " +
                           $"VALUES ({employeeID}, '{leaveType}', '{startDate}', '{endDate}', 'Pending')";
            int result = DatabaseHelper.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Leave application submitted.");
            else
                MessageBox.Show("Submission failed.");
        }

        private void btnViewLeaves_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            string query = $"SELECT * FROM LeaveApplications WHERE EmployeeID = {employeeID}";
            dgvLeaveHistory.DataSource = DatabaseHelper.ExecuteQuery(query);
        }
    }
}
