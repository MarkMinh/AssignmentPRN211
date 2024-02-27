namespace SalesWinApp
{
    partial class frmBuy
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
            txtQuantity = new TextBox();
            label2 = new Label();
            txtRequiredDays = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 56);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(196, 53);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 106);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 0;
            label2.Text = "Required Days";
            // 
            // txtRequiredDays
            // 
            txtRequiredDays.Location = new Point(196, 103);
            txtRequiredDays.Name = "txtRequiredDays";
            txtRequiredDays.Size = new Size(125, 27);
            txtRequiredDays.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 156);
            label3.Name = "label3";
            label3.Size = new Size(387, 20);
            label3.TabIndex = 0;
            label3.Text = "The earlier required date, the more freight you will pay !!!";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(66, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmBuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 258);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRequiredDays);
            Controls.Add(label2);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmBuy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtRequiredDays;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}