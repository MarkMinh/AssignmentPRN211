namespace SalesWinApp
{
    partial class frmUpdateOrder
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
            txtOrderId = new TextBox();
            label2 = new Label();
            txtMemberId = new TextBox();
            label3 = new Label();
            txtOrderDate = new TextBox();
            label4 = new Label();
            txtRequiredDate = new TextBox();
            label5 = new Label();
            txtShippedDate = new TextBox();
            label6 = new Label();
            txtFreight = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(151, 40);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(179, 27);
            txtOrderId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 85);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
            // 
            // txtMemberId
            // 
            txtMemberId.Enabled = false;
            txtMemberId.Location = new Point(151, 82);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(179, 27);
            txtMemberId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 129);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(151, 126);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(179, 27);
            txtOrderDate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 176);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 0;
            label4.Text = "Required Date";
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(151, 173);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(179, 27);
            txtRequiredDate.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 224);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 0;
            label5.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(151, 221);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(179, 27);
            txtShippedDate.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 269);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 0;
            label6.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(151, 266);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(179, 27);
            txtFreight.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(62, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(204, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmUpdateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(label6);
            Controls.Add(txtShippedDate);
            Controls.Add(label5);
            Controls.Add(txtRequiredDate);
            Controls.Add(label4);
            Controls.Add(txtOrderDate);
            Controls.Add(label3);
            Controls.Add(txtMemberId);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Name = "frmUpdateOrder";
            Text = "frmUpdateOrder";
            Load += frmUpdateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderId;
        private Label label2;
        private TextBox txtMemberId;
        private Label label3;
        private TextBox txtOrderDate;
        private Label label4;
        private TextBox txtRequiredDate;
        private Label label5;
        private TextBox txtShippedDate;
        private Label label6;
        private TextBox txtFreight;
        private Button btnSave;
        private Button btnCancel;
    }
}