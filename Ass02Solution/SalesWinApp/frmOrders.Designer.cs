namespace SalesWinApp
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
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
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 192);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(776, 299);
            dgvOrders.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(80, 141);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(260, 141);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(425, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Order ID";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(126, 21);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Member ID";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(126, 54);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 90);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(126, 87);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(125, 27);
            txtOrderDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 24);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 2;
            label4.Text = "Required Date";
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(469, 21);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(125, 27);
            txtRequiredDate.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 57);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 2;
            label5.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(469, 54);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(125, 27);
            txtShippedDate.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 90);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 2;
            label6.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(469, 87);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(125, 27);
            txtFreight.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(600, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
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
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrders);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
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
        private Button btnUpdate;
    }
}