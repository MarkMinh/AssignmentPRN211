namespace SalesWinApp
{
    partial class frmStatistic
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
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            dgvOrders = new DataGridView();
            txtOrderId = new TextBox();
            txtMemberId = new TextBox();
            txtOrderDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtShippedDate = new TextBox();
            txtFreight = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(47, 23);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 0;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(386, 23);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 1;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 196);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(663, 238);
            dgvOrders.TabIndex = 2;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(47, 98);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 3;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(47, 146);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 3;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(371, 146);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(125, 27);
            txtOrderDate.TabIndex = 3;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(209, 98);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.ReadOnly = true;
            txtRequiredDate.Size = new Size(125, 27);
            txtRequiredDate.TabIndex = 3;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(371, 98);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.ReadOnly = true;
            txtShippedDate.Size = new Size(125, 27);
            txtShippedDate.TabIndex = 3;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(209, 146);
            txtFreight.Name = "txtFreight";
            txtFreight.ReadOnly = true;
            txtFreight.Size = new Size(125, 27);
            txtFreight.TabIndex = 3;
            // 
            // frmStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 441);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemberId);
            Controls.Add(txtOrderId);
            Controls.Add(dgvOrders);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Name = "frmStatistic";
            Text = "frmStatistic";
            Load += frmStatistic_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridView dgvOrders;
        private TextBox txtOrderId;
        private TextBox txtMemberId;
        private TextBox txtOrderDate;
        private TextBox txtRequiredDate;
        private TextBox txtShippedDate;
        private TextBox txtFreight;
    }
}