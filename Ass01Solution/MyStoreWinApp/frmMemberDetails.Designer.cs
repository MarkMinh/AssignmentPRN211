namespace MyStoreWinApp
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
            label1 = new Label();
            txtMemberID = new TextBox();
            label2 = new Label();
            txtMemberName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 52);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(259, 49);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(333, 27);
            txtMemberID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(259, 100);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(333, 27);
            txtMemberName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 156);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(259, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 27);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 207);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(259, 204);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(333, 27);
            txtPass.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 259);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 0;
            label5.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(259, 256);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(333, 27);
            txtCity.TabIndex = 4;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 310);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 0;
            label6.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(259, 307);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(333, 27);
            txtCountry.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(272, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(477, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(txtCity);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtMemberName);
            Controls.Add(label2);
            Controls.Add(txtMemberID);
            Controls.Add(label1);
            Name = "frmMemberDetails";
            Text = "Form1";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtMemberName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPass;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtCountry;
        private Button btnSave;
        private Button btnCancel;
    }
}