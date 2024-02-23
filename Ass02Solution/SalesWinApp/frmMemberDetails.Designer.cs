namespace SalesWinApp
{
    partial class frmMemberDetails
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
            ID = new Label();
            txtMemberId = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCompany = new TextBox();
            label4 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            txtCountry = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(66, 37);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(188, 34);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(232, 27);
            txtMemberId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 27);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 147);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 0;
            label3.Text = "Company Name";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(188, 144);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(232, 27);
            txtCompany.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 207);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 0;
            label4.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(188, 204);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(232, 27);
            txtCity.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 261);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 0;
            label5.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(188, 258);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(232, 27);
            txtCountry.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 319);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(127, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(284, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtCompany);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtMemberId);
            Controls.Add(ID);
            Name = "frmMemberDetails";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private TextBox txtMemberId;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCompany;
        private Label label4;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtCountry;
        private Label label6;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}