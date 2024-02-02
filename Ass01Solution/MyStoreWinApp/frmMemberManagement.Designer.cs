namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMember = new DataGridView();
            btnClose = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            lbMemberId = new Label();
            txtMemberID = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPass = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbMemberName = new Label();
            txtMemberName = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            txtSearchID = new TextBox();
            label1 = new Label();
            btnSort = new Button();
            cbCountry = new ComboBox();
            btnFilter = new Button();
            cbCity = new ComboBox();
            label3 = new Label();
            txtSearchName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(0, 204);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.Size = new Size(915, 213);
            dgvMember.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(418, 423);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(118, 143);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button2_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(271, 143);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(456, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(38, 17);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(24, 20);
            lbMemberId.TabIndex = 2;
            lbMemberId.Text = "ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(90, 14);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(176, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(34, 102);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            lbEmail.Click += lbEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(295, 17);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(379, 14);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(171, 27);
            txtPass.TabIndex = 4;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(295, 59);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 2;
            lbCity.Text = "City";
            lbCity.Click += lbCity_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(379, 56);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(171, 27);
            txtCity.TabIndex = 5;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(35, 59);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(49, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Name";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(90, 56);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(176, 27);
            txtMemberName.TabIndex = 2;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(295, 98);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 2;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(379, 95);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(171, 27);
            txtCountry.TabIndex = 6;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(718, 14);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(125, 27);
            txtSearchID.TabIndex = 7;
            txtSearchID.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "SearchByID";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(634, 143);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(103, 29);
            btnSort.TabIndex = 13;
            btnSort.Text = "SortByName";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(678, 93);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(110, 28);
            cbCountry.TabIndex = 5;
            cbCountry.DropDown += cbCountry_DropDown;
            cbCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cbCountry.Click += cbCountry_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(578, 93);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(794, 93);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(103, 28);
            cbCity.TabIndex = 5;
            cbCity.DropDown += cbCity_DropDown;
            cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
            cbCity.Click += cbCountry_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 50);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "SearchByName";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(718, 47);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(125, 27);
            txtSearchName.TabIndex = 7;
            txtSearchName.TextChanged += textBox1_TextChanged;
            // 
            // frmMemberManagement
            // 
            AcceptButton = btnLoad;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 453);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(txtSearchName);
            Controls.Add(txtSearchID);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberId);
            Controls.Add(btnSort);
            Controls.Add(btnFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(dgvMember);
            Name = "frmMemberManagement";
            Text = "Form1";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Button btnClose;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Label lbMemberId;
        private TextBox txtMemberID;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPass;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private Label lbCountry;
        private TextBox txtCountry;
        private TextBox txtSearchID;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button btnSort;
        private ComboBox cbCountry;
        private Button btnFilter;
        private ComboBox cbCity;
        private Label label3;
        private TextBox txtSearchName;
    }
}