
namespace SAD2
{
    partial class frmInventory
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
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.gridStockIn = new System.Windows.Forms.DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventoryWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventorySubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.grpStockInStockOut = new System.Windows.Forms.GroupBox();
            this.btnStockRecordDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colStockRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockRecordEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockRecordAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).BeginInit();
            this.grpStockInStockOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.gridStockIn);
            this.grpInventory.Controls.Add(this.btnViewAll);
            this.grpInventory.Controls.Add(this.comboBox1);
            this.grpInventory.Controls.Add(this.lblColor);
            this.grpInventory.Controls.Add(this.cmbType);
            this.grpInventory.Controls.Add(this.lblType);
            this.grpInventory.Location = new System.Drawing.Point(28, 32);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1227, 269);
            this.grpInventory.TabIndex = 0;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // gridStockIn
            // 
            this.gridStockIn.AllowUserToAddRows = false;
            this.gridStockIn.AllowUserToDeleteRows = false;
            this.gridStockIn.AllowUserToResizeColumns = false;
            this.gridStockIn.AllowUserToResizeRows = false;
            this.gridStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockID,
            this.colInventoryType,
            this.colInventoryName,
            this.colInventoryWeight,
            this.colInventoryQuantity,
            this.colInventorySubtotal});
            this.gridStockIn.Location = new System.Drawing.Point(24, 77);
            this.gridStockIn.Name = "gridStockIn";
            this.gridStockIn.ReadOnly = true;
            this.gridStockIn.RowTemplate.Height = 25;
            this.gridStockIn.Size = new System.Drawing.Size(1177, 164);
            this.gridStockIn.TabIndex = 23;
            // 
            // colStockID
            // 
            this.colStockID.HeaderText = "StockID";
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            // 
            // colInventoryType
            // 
            this.colInventoryType.HeaderText = "Type";
            this.colInventoryType.Name = "colInventoryType";
            this.colInventoryType.ReadOnly = true;
            // 
            // colInventoryName
            // 
            this.colInventoryName.HeaderText = "Name";
            this.colInventoryName.Name = "colInventoryName";
            this.colInventoryName.ReadOnly = true;
            // 
            // colInventoryWeight
            // 
            this.colInventoryWeight.HeaderText = "Weight";
            this.colInventoryWeight.Name = "colInventoryWeight";
            this.colInventoryWeight.ReadOnly = true;
            // 
            // colInventoryQuantity
            // 
            this.colInventoryQuantity.HeaderText = "Quantity";
            this.colInventoryQuantity.Name = "colInventoryQuantity";
            this.colInventoryQuantity.ReadOnly = true;
            // 
            // colInventorySubtotal
            // 
            this.colInventorySubtotal.HeaderText = "Subtotal";
            this.colInventorySubtotal.Name = "colInventorySubtotal";
            this.colInventorySubtotal.ReadOnly = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(736, 35);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(146, 23);
            this.btnViewAll.TabIndex = 22;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(416, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(374, 39);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 20;
            this.lblColor.Text = "Color";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(61, 35);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(253, 23);
            this.cmbType.TabIndex = 19;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 39);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 15);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Type";
            // 
            // grpStockInStockOut
            // 
            this.grpStockInStockOut.Controls.Add(this.btnStockRecordDetails);
            this.grpStockInStockOut.Controls.Add(this.dataGridView1);
            this.grpStockInStockOut.Location = new System.Drawing.Point(28, 322);
            this.grpStockInStockOut.Name = "grpStockInStockOut";
            this.grpStockInStockOut.Size = new System.Drawing.Size(1227, 245);
            this.grpStockInStockOut.TabIndex = 1;
            this.grpStockInStockOut.TabStop = false;
            this.grpStockInStockOut.Text = "Stock In and Stock Out Record";
            // 
            // btnStockRecordDetails
            // 
            this.btnStockRecordDetails.Location = new System.Drawing.Point(1076, 208);
            this.btnStockRecordDetails.Name = "btnStockRecordDetails";
            this.btnStockRecordDetails.Size = new System.Drawing.Size(125, 23);
            this.btnStockRecordDetails.TabIndex = 5;
            this.btnStockRecordDetails.Text = "Details";
            this.btnStockRecordDetails.UseVisualStyleBackColor = true;
            this.btnStockRecordDetails.Click += new System.EventHandler(this.btnStockRecordDetails_Click);
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
            this.colStockRecordID,
            this.colDateAndTime,
            this.colStockRecordEmployee,
            this.colStockRecordAction});
            this.dataGridView1.Location = new System.Drawing.Point(24, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 159);
            this.dataGridView1.TabIndex = 24;
            // 
            // colStockRecordID
            // 
            this.colStockRecordID.HeaderText = "Stock In/Out ID";
            this.colStockRecordID.Name = "colStockRecordID";
            // 
            // colDateAndTime
            // 
            this.colDateAndTime.HeaderText = "Stock In Date and Time";
            this.colDateAndTime.Name = "colDateAndTime";
            // 
            // colStockRecordEmployee
            // 
            this.colStockRecordEmployee.HeaderText = "Employee";
            this.colStockRecordEmployee.Name = "colStockRecordEmployee";
            // 
            // colStockRecordAction
            // 
            this.colStockRecordAction.HeaderText = "Action";
            this.colStockRecordAction.Name = "colStockRecordAction";
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(499, 589);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(125, 23);
            this.btnStockIn.TabIndex = 2;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(659, 589);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(125, 23);
            this.btnStockOut.TabIndex = 3;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1104, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1283, 632);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.grpStockInStockOut);
            this.Controls.Add(this.grpInventory);
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).EndInit();
            this.grpStockInStockOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView gridStockIn;
        private System.Windows.Forms.GroupBox grpStockInStockOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventorySubtotal;
        private System.Windows.Forms.Button btnStockRecordDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRecordEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRecordAction;
    }
}