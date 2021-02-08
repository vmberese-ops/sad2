
namespace SAD2
{
    partial class frmStockOut
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
            this.grpStockIn = new System.Windows.Forms.GroupBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtStockInID = new System.Windows.Forms.TextBox();
            this.lblStockOutID = new System.Windows.Forms.Label();
            this.gridStockIn = new System.Windows.Forms.DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStockOutItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveFromStockOut = new System.Windows.Forms.Button();
            this.txtTruckTotalWeight = new System.Windows.Forms.TextBox();
            this.lblTruckTotalWeight = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.GroupBox();
            this.btnAddToStockOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.grpStockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpStockOutItems.SuspendLayout();
            this.btnInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockIn
            // 
            this.grpStockIn.Controls.Add(this.txtEmployee);
            this.grpStockIn.Controls.Add(this.lblEmployee);
            this.grpStockIn.Controls.Add(this.txtStockInID);
            this.grpStockIn.Controls.Add(this.lblStockOutID);
            this.grpStockIn.Location = new System.Drawing.Point(23, 23);
            this.grpStockIn.Name = "grpStockIn";
            this.grpStockIn.Size = new System.Drawing.Size(593, 117);
            this.grpStockIn.TabIndex = 2;
            this.grpStockIn.TabStop = false;
            this.grpStockIn.Text = "Stock In";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(218, 67);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(236, 23);
            this.txtEmployee.TabIndex = 4;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(153, 71);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // txtStockInID
            // 
            this.txtStockInID.Location = new System.Drawing.Point(218, 27);
            this.txtStockInID.Name = "txtStockInID";
            this.txtStockInID.Size = new System.Drawing.Size(236, 23);
            this.txtStockInID.TabIndex = 2;
            // 
            // lblStockOutID
            // 
            this.lblStockOutID.AutoSize = true;
            this.lblStockOutID.Location = new System.Drawing.Point(139, 31);
            this.lblStockOutID.Name = "lblStockOutID";
            this.lblStockOutID.Size = new System.Drawing.Size(73, 15);
            this.lblStockOutID.TabIndex = 2;
            this.lblStockOutID.Text = "Stock Out ID";
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
            this.colItemType,
            this.colItemName,
            this.colItemWeight,
            this.colItemQuantity,
            this.colItemSubtotal});
            this.gridStockIn.Location = new System.Drawing.Point(16, 27);
            this.gridStockIn.Name = "gridStockIn";
            this.gridStockIn.ReadOnly = true;
            this.gridStockIn.RowTemplate.Height = 25;
            this.gridStockIn.Size = new System.Drawing.Size(561, 306);
            this.gridStockIn.TabIndex = 17;
            // 
            // colStockID
            // 
            this.colStockID.HeaderText = "StockID";
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            // 
            // colItemType
            // 
            this.colItemType.HeaderText = "Type";
            this.colItemType.Name = "colItemType";
            this.colItemType.ReadOnly = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(17, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(583, 438);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // grpStockOutItems
            // 
            this.grpStockOutItems.Controls.Add(this.btnRemoveFromStockOut);
            this.grpStockOutItems.Controls.Add(this.txtTruckTotalWeight);
            this.grpStockOutItems.Controls.Add(this.lblTruckTotalWeight);
            this.grpStockOutItems.Controls.Add(this.dataGridView1);
            this.grpStockOutItems.Location = new System.Drawing.Point(634, 23);
            this.grpStockOutItems.Name = "grpStockOutItems";
            this.grpStockOutItems.Size = new System.Drawing.Size(617, 534);
            this.grpStockOutItems.TabIndex = 19;
            this.grpStockOutItems.TabStop = false;
            this.grpStockOutItems.Text = "Stock Out Items";
            // 
            // btnRemoveFromStockOut
            // 
            this.btnRemoveFromStockOut.Location = new System.Drawing.Point(17, 486);
            this.btnRemoveFromStockOut.Name = "btnRemoveFromStockOut";
            this.btnRemoveFromStockOut.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveFromStockOut.TabIndex = 23;
            this.btnRemoveFromStockOut.Text = "Remove";
            this.btnRemoveFromStockOut.UseVisualStyleBackColor = true;
            // 
            // txtTruckTotalWeight
            // 
            this.txtTruckTotalWeight.Enabled = false;
            this.txtTruckTotalWeight.Location = new System.Drawing.Point(437, 486);
            this.txtTruckTotalWeight.Name = "txtTruckTotalWeight";
            this.txtTruckTotalWeight.Size = new System.Drawing.Size(163, 23);
            this.txtTruckTotalWeight.TabIndex = 6;
            // 
            // lblTruckTotalWeight
            // 
            this.lblTruckTotalWeight.AutoSize = true;
            this.lblTruckTotalWeight.Location = new System.Drawing.Point(327, 490);
            this.lblTruckTotalWeight.Name = "lblTruckTotalWeight";
            this.lblTruckTotalWeight.Size = new System.Drawing.Size(104, 15);
            this.lblTruckTotalWeight.TabIndex = 5;
            this.lblTruckTotalWeight.Text = "Truck Total Weight";
            // 
            // btnInventory
            // 
            this.btnInventory.Controls.Add(this.btnAddToStockOut);
            this.btnInventory.Controls.Add(this.gridStockIn);
            this.btnInventory.Location = new System.Drawing.Point(23, 157);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(592, 400);
            this.btnInventory.TabIndex = 20;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Inventory";
            // 
            // btnAddToStockOut
            // 
            this.btnAddToStockOut.Location = new System.Drawing.Point(448, 351);
            this.btnAddToStockOut.Name = "btnAddToStockOut";
            this.btnAddToStockOut.Size = new System.Drawing.Size(129, 23);
            this.btnAddToStockOut.TabIndex = 22;
            this.btnAddToStockOut.Text = "Add";
            this.btnAddToStockOut.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(977, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(1104, 575);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(147, 23);
            this.btnStockOut.TabIndex = 22;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // frmStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 620);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.grpStockOutItems);
            this.Controls.Add(this.grpStockIn);
            this.MaximizeBox = false;
            this.Name = "frmStockOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out";
            this.grpStockIn.ResumeLayout(false);
            this.grpStockIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpStockOutItems.ResumeLayout(false);
            this.grpStockOutItems.PerformLayout();
            this.btnInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockIn;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtStockInID;
        private System.Windows.Forms.Label lblStockOutID;
        private System.Windows.Forms.DataGridView gridStockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSubtotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grpStockOutItems;
        private System.Windows.Forms.Button btnRemoveFromStockOut;
        private System.Windows.Forms.TextBox txtTruckTotalWeight;
        private System.Windows.Forms.Label lblTruckTotalWeight;
        private System.Windows.Forms.GroupBox btnInventory;
        private System.Windows.Forms.Button btnAddToStockOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStockOut;
    }
}