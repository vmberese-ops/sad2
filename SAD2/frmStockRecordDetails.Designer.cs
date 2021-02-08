
namespace SAD2
{
    partial class frmStockRecordDetails
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
            this.grpStockRecordDetails = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblStockRecordID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpStockRecordDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStockRecordDetails
            // 
            this.grpStockRecordDetails.Controls.Add(this.textBox4);
            this.grpStockRecordDetails.Controls.Add(this.textBox3);
            this.grpStockRecordDetails.Controls.Add(this.textBox2);
            this.grpStockRecordDetails.Controls.Add(this.textBox1);
            this.grpStockRecordDetails.Controls.Add(this.lblAction);
            this.grpStockRecordDetails.Controls.Add(this.lblEmployee);
            this.grpStockRecordDetails.Controls.Add(this.lblDateTime);
            this.grpStockRecordDetails.Controls.Add(this.lblStockRecordID);
            this.grpStockRecordDetails.Location = new System.Drawing.Point(20, 15);
            this.grpStockRecordDetails.Name = "grpStockRecordDetails";
            this.grpStockRecordDetails.Size = new System.Drawing.Size(756, 179);
            this.grpStockRecordDetails.TabIndex = 0;
            this.grpStockRecordDetails.TabStop = false;
            this.grpStockRecordDetails.Text = "Stock Record Details";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(147, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(147, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(147, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(147, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(84, 133);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(42, 15);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(67, 100);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(43, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(83, 15);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Date and Time";
            // 
            // lblStockRecordID
            // 
            this.lblStockRecordID.AutoSize = true;
            this.lblStockRecordID.Location = new System.Drawing.Point(36, 67);
            this.lblStockRecordID.Name = "lblStockRecordID";
            this.lblStockRecordID.Size = new System.Drawing.Size(90, 15);
            this.lblStockRecordID.TabIndex = 1;
            this.lblStockRecordID.Text = "Stock Record ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockID,
            this.colItemName,
            this.colItemWeight,
            this.colItemQuantity,
            this.colItemSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(20, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(756, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // colStockID
            // 
            this.colStockID.HeaderText = "Stock ID";
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colItemWeight
            // 
            this.colItemWeight.HeaderText = "Weight";
            this.colItemWeight.Name = "colItemWeight";
            this.colItemWeight.ReadOnly = true;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.ReadOnly = true;
            // 
            // colItemSubtotal
            // 
            this.colItemSubtotal.HeaderText = "Subtotal";
            this.colItemSubtotal.Name = "colItemSubtotal";
            this.colItemSubtotal.ReadOnly = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(595, 498);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(181, 23);
            this.txtSubtotal.TabIndex = 9;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(538, 502);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 15);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(346, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStockRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpStockRecordDetails);
            this.MaximizeBox = false;
            this.Name = "frmStockRecordDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Record Details";
            this.grpStockRecordDetails.ResumeLayout(false);
            this.grpStockRecordDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockRecordDetails;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblStockRecordID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnClose;
    }
}