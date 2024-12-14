namespace LeaveManagementSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeaveID = new System.Windows.Forms.TextBox();
            this.btnApproveLeave = new System.Windows.Forms.Button();
            this.btnRejectLeave = new System.Windows.Forms.Button();
            this.btnViewAllLeaves = new System.Windows.Forms.Button();
            this.dgvAllLeaves = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.cmbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLeaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave ID";
            // 
            // txtLeaveID
            // 
            this.txtLeaveID.Location = new System.Drawing.Point(571, 61);
            this.txtLeaveID.Name = "txtLeaveID";
            this.txtLeaveID.Size = new System.Drawing.Size(100, 22);
            this.txtLeaveID.TabIndex = 1;
            // 
            // btnApproveLeave
            // 
            this.btnApproveLeave.Location = new System.Drawing.Point(571, 106);
            this.btnApproveLeave.Name = "btnApproveLeave";
            this.btnApproveLeave.Size = new System.Drawing.Size(75, 23);
            this.btnApproveLeave.TabIndex = 2;
            this.btnApproveLeave.Text = "Approve";
            this.btnApproveLeave.UseVisualStyleBackColor = true;
            this.btnApproveLeave.Click += new System.EventHandler(this.btnApproveLeave_Click);
            // 
            // btnRejectLeave
            // 
            this.btnRejectLeave.Location = new System.Drawing.Point(571, 153);
            this.btnRejectLeave.Name = "btnRejectLeave";
            this.btnRejectLeave.Size = new System.Drawing.Size(75, 23);
            this.btnRejectLeave.TabIndex = 3;
            this.btnRejectLeave.Text = "Reject";
            this.btnRejectLeave.UseVisualStyleBackColor = true;
            this.btnRejectLeave.Click += new System.EventHandler(this.btnRejectLeave_Click);
            // 
            // btnViewAllLeaves
            // 
            this.btnViewAllLeaves.Location = new System.Drawing.Point(571, 215);
            this.btnViewAllLeaves.Name = "btnViewAllLeaves";
            this.btnViewAllLeaves.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllLeaves.TabIndex = 4;
            this.btnViewAllLeaves.Text = "View";
            this.btnViewAllLeaves.UseVisualStyleBackColor = true;
            this.btnViewAllLeaves.Click += new System.EventHandler(this.btnViewAllLeaves_Click);
            // 
            // dgvAllLeaves
            // 
            this.dgvAllLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLeaves.Location = new System.Drawing.Point(460, 288);
            this.dgvAllLeaves.Name = "dgvAllLeaves";
            this.dgvAllLeaves.RowHeadersWidth = 51;
            this.dgvAllLeaves.RowTemplate.Height = 24;
            this.dgvAllLeaves.Size = new System.Drawing.Size(308, 150);
            this.dgvAllLeaves.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(123, 58);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(123, 197);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 11;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(123, 100);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeePassword.TabIndex = 13;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(13, 243);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(175, 243);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 15;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(94, 243);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 16;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // cmbEmployeeRole
            // 
            this.cmbEmployeeRole.FormattingEnabled = true;
            this.cmbEmployeeRole.Items.AddRange(new object[] {
            "Employee",
            "Admin"});
            this.cmbEmployeeRole.Location = new System.Drawing.Point(123, 152);
            this.cmbEmployeeRole.Name = "cmbEmployeeRole";
            this.cmbEmployeeRole.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployeeRole.TabIndex = 17;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(29, 288);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(308, 150);
            this.dgvEmployees.TabIndex = 18;
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.Location = new System.Drawing.Point(262, 243);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnViewEmployees.TabIndex = 19;
            this.btnViewEmployees.Text = "View";
            this.btnViewEmployees.UseVisualStyleBackColor = true;
            this.btnViewEmployees.Click += new System.EventHandler(this.btnViewEmployees_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "User Management";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Leave Management";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewEmployees);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.cmbEmployeeRole);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtEmployeePassword);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAllLeaves);
            this.Controls.Add(this.btnViewAllLeaves);
            this.Controls.Add(this.btnRejectLeave);
            this.Controls.Add(this.btnApproveLeave);
            this.Controls.Add(this.txtLeaveID);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLeaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeaveID;
        private System.Windows.Forms.Button btnApproveLeave;
        private System.Windows.Forms.Button btnRejectLeave;
        private System.Windows.Forms.Button btnViewAllLeaves;
        private System.Windows.Forms.DataGridView dgvAllLeaves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.ComboBox cmbEmployeeRole;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}