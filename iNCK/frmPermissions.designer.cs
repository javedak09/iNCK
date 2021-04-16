namespace iNCK
{
    partial class frmPermissions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAkuID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGUser = new System.Windows.Forms.DataGridView();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCancel1 = new System.Windows.Forms.Button();
            this.cmdDeleteUser = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cboForms = new System.Windows.Forms.ComboBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGPermissions = new System.Windows.Forms.DataGridView();
            this.cboPermissions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RevokePermissions = new System.Windows.Forms.Button();
            this.cmdGrantPermission = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAkuID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEmpNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboLocation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmdCancel1);
            this.groupBox1.Controls.Add(this.cmdDeleteUser);
            this.groupBox1.Controls.Add(this.cmdAddUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.txtPasswd);
            this.groupBox1.Controls.Add(this.txtConfirmPasswd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserManagement";
            // 
            // txtAkuID
            // 
            this.txtAkuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkuID.Location = new System.Drawing.Point(411, 14);
            this.txtAkuID.MaxLength = 30;
            this.txtAkuID.Name = "txtAkuID";
            this.txtAkuID.Size = new System.Drawing.Size(212, 20);
            this.txtAkuID.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(408, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "(without .aku.edu)";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.BackColor = System.Drawing.Color.White;
            this.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNo.Location = new System.Drawing.Point(411, 75);
            this.txtEmpNo.Mask = "999999";
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(72, 20);
            this.txtEmpNo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Emp No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aku ID:";
            // 
            // cboLocation
            // 
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(186, 97);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(100, 21);
            this.cboLocation.TabIndex = 7;            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGUser);
            this.groupBox2.Location = new System.Drawing.Point(6, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 168);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DGUser
            // 
            this.DGUser.AllowUserToAddRows = false;
            this.DGUser.AllowUserToDeleteRows = false;
            this.DGUser.CausesValidation = false;
            this.DGUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUser.Location = new System.Drawing.Point(4, 12);
            this.DGUser.MultiSelect = false;
            this.DGUser.Name = "DGUser";
            this.DGUser.ReadOnly = true;
            this.DGUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGUser.Size = new System.Drawing.Size(637, 150);
            this.DGUser.TabIndex = 0;
            this.DGUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUser_CellClick);
            this.DGUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUser_CellContentClick);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(186, 122);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 21);
            this.cboStatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "User Status:";
            // 
            // cmdCancel1
            // 
            this.cmdCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel1.Location = new System.Drawing.Point(269, 150);
            this.cmdCancel1.Name = "cmdCancel1";
            this.cmdCancel1.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel1.TabIndex = 13;
            this.cmdCancel1.Text = "Cancel";
            this.cmdCancel1.UseVisualStyleBackColor = true;
            this.cmdCancel1.Click += new System.EventHandler(this.cmdCancel1_Click);
            // 
            // cmdDeleteUser
            // 
            this.cmdDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteUser.Location = new System.Drawing.Point(188, 150);
            this.cmdDeleteUser.Name = "cmdDeleteUser";
            this.cmdDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteUser.TabIndex = 12;
            this.cmdDeleteUser.Text = "Delete User";
            this.cmdDeleteUser.UseVisualStyleBackColor = true;
            this.cmdDeleteUser.Click += new System.EventHandler(this.cmdDeleteUser_Click);
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddUser.Location = new System.Drawing.Point(106, 150);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(75, 23);
            this.cmdAddUser.TabIndex = 11;
            this.cmdAddUser.Text = "Add User";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(186, 19);
            this.txtUserID.MaxLength = 15;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 4;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswd.Location = new System.Drawing.Point(186, 45);
            this.txtPasswd.MaxLength = 15;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 5;
            // 
            // txtConfirmPasswd
            // 
            this.txtConfirmPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswd.Location = new System.Drawing.Point(186, 71);
            this.txtConfirmPasswd.MaxLength = 15;
            this.txtConfirmPasswd.Name = "txtConfirmPasswd";
            this.txtConfirmPasswd.PasswordChar = '*';
            this.txtConfirmPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPasswd.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdCancel);
            this.groupBox3.Controls.Add(this.cboForms);
            this.groupBox3.Controls.Add(this.cboUser);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cboPermissions);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.RevokePermissions);
            this.groupBox3.Controls.Add(this.cmdGrantPermission);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 354);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Permissions";
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(322, 115);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 16;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cboForms
            // 
            this.cboForms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForms.FormattingEnabled = true;
            this.cboForms.Items.AddRange(new object[] {
            "Select Status",
            "Enable",
            "Disable"});
            this.cboForms.Location = new System.Drawing.Point(186, 55);
            this.cboForms.Name = "cboForms";
            this.cboForms.Size = new System.Drawing.Size(100, 21);
            this.cboForms.TabIndex = 15;
            this.cboForms.SelectedIndexChanged += new System.EventHandler(this.cboForms_SelectedIndexChanged);
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Select Status",
            "Enable",
            "Disable"});
            this.cboUser.Location = new System.Drawing.Point(185, 28);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(100, 21);
            this.cboUser.TabIndex = 14;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGPermissions);
            this.groupBox4.Location = new System.Drawing.Point(6, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 202);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // DGPermissions
            // 
            this.DGPermissions.AllowUserToAddRows = false;
            this.DGPermissions.AllowUserToDeleteRows = false;
            this.DGPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPermissions.Location = new System.Drawing.Point(3, 16);
            this.DGPermissions.MultiSelect = false;
            this.DGPermissions.Name = "DGPermissions";
            this.DGPermissions.ReadOnly = true;
            this.DGPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPermissions.Size = new System.Drawing.Size(452, 175);
            this.DGPermissions.TabIndex = 0;
            this.DGPermissions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPermissions_CellClick);
            // 
            // cboPermissions
            // 
            this.cboPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermissions.FormattingEnabled = true;
            this.cboPermissions.Location = new System.Drawing.Point(186, 82);
            this.cboPermissions.Name = "cboPermissions";
            this.cboPermissions.Size = new System.Drawing.Size(100, 21);
            this.cboPermissions.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Permissions:";
            // 
            // RevokePermissions
            // 
            this.RevokePermissions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RevokePermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokePermissions.Location = new System.Drawing.Point(192, 115);
            this.RevokePermissions.Name = "RevokePermissions";
            this.RevokePermissions.Size = new System.Drawing.Size(124, 23);
            this.RevokePermissions.TabIndex = 9;
            this.RevokePermissions.Text = "Revoke Permissions";
            this.RevokePermissions.UseVisualStyleBackColor = true;
            this.RevokePermissions.Click += new System.EventHandler(this.RevokePermissions_Click);
            // 
            // cmdGrantPermission
            // 
            this.cmdGrantPermission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGrantPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrantPermission.Location = new System.Drawing.Point(79, 115);
            this.cmdGrantPermission.Name = "cmdGrantPermission";
            this.cmdGrantPermission.Size = new System.Drawing.Size(107, 23);
            this.cmdGrantPermission.TabIndex = 7;
            this.cmdGrantPermission.Text = "Grant Permission";
            this.cmdGrantPermission.UseVisualStyleBackColor = true;
            this.cmdGrantPermission.Click += new System.EventHandler(this.cmdGrantPermission_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "UserID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Forms:";
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 723);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Permissions";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPermissions_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtConfirmPasswd;
        private System.Windows.Forms.Button cmdCancel1;
        private System.Windows.Forms.Button cmdDeleteUser;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGPermissions;
        private System.Windows.Forms.ComboBox cboPermissions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RevokePermissions;
        private System.Windows.Forms.Button cmdGrantPermission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.ComboBox cboForms;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtEmpNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAkuID;
    }
}