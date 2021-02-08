
namespace SAD2
{
    partial class FrmStockIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpStockIn = new System.Windows.Forms.GroupBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtStockInID = new System.Windows.Forms.TextBox();
            this.lblStockInID = new System.Windows.Forms.Label();
            this.grpStockInItems = new System.Windows.Forms.GroupBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblItemWeight = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.grpStockInDetails = new System.Windows.Forms.GroupBox();
            this.gridStockIn = new System.Windows.Forms.DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.txtSubtotalStockIn = new System.Windows.Forms.TextBox();
            this.lblSubtotalStockIn = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpStockIn.SuspendLayout();
            this.grpStockInItems.SuspendLayout();
            this.grpStockInDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStockIn
            // 
            this.grpStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockIn.Controls.Add(this.txtEmployee);
            this.grpStockIn.Controls.Add(this.lblEmployee);
            this.grpStockIn.Controls.Add(this.txtStockInID);
            this.grpStockIn.Controls.Add(this.lblStockInID);
            this.grpStockIn.Location = new System.Drawing.Point(33, 31);
            this.grpStockIn.Name = "grpStockIn";
            this.grpStockIn.Size = new System.Drawing.Size(431, 117);
            this.grpStockIn.TabIndex = 1;
            this.grpStockIn.TabStop = false;
            this.grpStockIn.Text = "Stock In";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(132, 67);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(236, 23);
            this.txtEmployee.TabIndex = 4;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(67, 71);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(59, 15);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // txtStockInID
            // 
            this.txtStockInID.Location = new System.Drawing.Point(132, 27);
            this.txtStockInID.Name = "txtStockInID";
            this.txtStockInID.Size = new System.Drawing.Size(236, 23);
            this.txtStockInID.TabIndex = 2;
            // 
            // lblStockInID
            // 
            this.lblStockInID.AutoSize = true;
            this.lblStockInID.Location = new System.Drawing.Point(63, 31);
            this.lblStockInID.Name = "lblStockInID";
            this.lblStockInID.Size = new System.Drawing.Size(63, 15);
            this.lblStockInID.TabIndex = 2;
            this.lblStockInID.Text = "Stock In ID";
            // 
            // grpStockInItems
            // 
            this.grpStockInItems.Controls.Add(this.txtItemType);
            this.grpStockInItems.Controls.Add(this.lblItemType);
            this.grpStockInItems.Controls.Add(this.btnDelete);
            this.grpStockInItems.Controls.Add(this.btnUpdate);
            this.grpStockInItems.Controls.Add(this.btnAddStock);
            this.grpStockInItems.Controls.Add(this.txtSubtotal);
            this.grpStockInItems.Controls.Add(this.lblSubtotal);
            this.grpStockInItems.Controls.Add(this.txtItemQuantity);
            this.grpStockInItems.Controls.Add(this.lblQuantity);
            this.grpStockInItems.Controls.Add(this.textBox1);
            this.grpStockInItems.Controls.Add(this.lblItemWeight);
            this.grpStockInItems.Controls.Add(this.txtItemName);
            this.grpStockInItems.Controls.Add(this.lblItemName);
            this.grpStockInItems.Controls.Add(this.txtItemID);
            this.grpStockInItems.Controls.Add(this.lblItemID);
            this.grpStockInItems.Location = new System.Drawing.Point(33, 169);
            this.grpStockInItems.Name = "grpStockInItems";
            this.grpStockInItems.Size = new System.Drawing.Size(431, 364);
            this.grpStockInItems.TabIndex = 2;
            this.grpStockInItems.TabStop = false;
            this.grpStockInItems.Text = "Items";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(132, 82);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(236, 23);
            this.txtItemType.TabIndex = 18;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(66, 86);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(58, 15);
            this.lblItemType.TabIndex = 17;
            this.lblItemType.Text = "Item Type";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(279, 311);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(89, 23);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(132, 254);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(236, 23);
            this.txtSubtotal.TabIndex = 13;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(73, 258);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 15);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(132, 211);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(236, 23);
            this.txtItemQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(71, 215);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 9;
            // 
            // lblItemWeight
            // 
            this.lblItemWeight.AutoSize = true;
            this.lblItemWeight.Location = new System.Drawing.Point(52, 172);
            this.lblItemWeight.Name = "lblItemWeight";
            this.lblItemWeight.Size = new System.Drawing.Size(72, 15);
            this.lblItemWeight.TabIndex = 8;
            this.lblItemWeight.Text = "Item Weight";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(132, 125);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(236, 23);
            this.txtItemName.TabIndex = 7;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(58, 129);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(66, 15);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "Item Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(132, 39);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(236, 23);
            this.txtItemID.TabIndex = 5;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(79, 43);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(45, 15);
            this.lblItemID.TabIndex = 5;
            this.lblItemID.Text = "Item ID";
            // 
            // grpStockInDetails
            // 
            this.grpStockInDetails.Controls.Add(this.gridStockIn);
            this.grpStockInDetails.Controls.Add(this.btnStockIn);
            this.grpStockInDetails.Controls.Add(this.txtSubtotalStockIn);
            this.grpStockInDetails.Controls.Add(this.lblSubtotalStockIn);
            this.grpStockInDetails.Location = new System.Drawing.Point(509, 31);
            this.grpStockInDetails.Name = "grpStockInDetails";
            this.grpStockInDetails.Size = new System.Drawing.Size(766, 502);
            this.grpStockInDetails.TabIndex = 3;
            this.grpStockInDetails.TabStop = false;
            this.grpStockInDetails.Text = "Products";
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
            this.gridStockIn.Location = new System.Drawing.Point(21, 31);
            this.gridStockIn.Name = "gridStockIn";
            this.gridStockIn.ReadOnly = true;
            this.gridStockIn.RowTemplate.Height = 25;
            this.gridStockIn.Size = new System.Drawing.Size(724, 358);
            this.gridStockIn.TabIndex = 16;
            this.gridStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStockIn_CellContentClick);
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
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(630, 449);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(115, 23);
            this.btnStockIn.TabIndex = 15;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            // 
            // txtSubtotalStockIn
            // 
            this.txtSubtotalStockIn.Enabled = false;
            this.txtSubtotalStockIn.Location = new System.Drawing.Point(581, 408);
            this.txtSubtotalStockIn.Name = "txtSubtotalStockIn";
            this.txtSubtotalStockIn.Size = new System.Drawing.Size(164, 23);
            this.txtSubtotalStockIn.TabIndex = 15;
            // 
            // lblSubtotalStockIn
            // 
            this.lblSubtotalStockIn.AutoSize = true;
            this.lblSubtotalStockIn.Location = new System.Drawing.Point(524, 411);
            this.lblSubtotalStockIn.Name = "lblSubtotalStockIn";
            this.lblSubtotalStockIn.Size = new System.Drawing.Size(51, 15);
            this.lblSubtotalStockIn.TabIndex = 15;
            this.lblSubtotalStockIn.Text = "Subtotal";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(610, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1308, 593);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpStockInDetails);
            this.Controls.Add(this.grpStockInItems);
            this.Controls.Add(this.grpStockIn);
            this.MaximizeBox = false;
            this.Name = "FrmStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.grpStockIn.ResumeLayout(false);
            this.grpStockIn.PerformLayout();
            this.grpStockInItems.ResumeLayout(false);
            this.grpStockInItems.PerformLayout();
            this.grpStockInDetails.ResumeLayout(false);
            this.grpStockInDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockIn;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtStockInID;
        private System.Windows.Forms.Label lblStockInID;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.GroupBox grpStockInItems;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblItemWeight;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.GroupBox grpStockInDetails;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.TextBox txtSubtotalStockIn;
        private System.Windows.Forms.Label lblSubtotalStockIn;
        private System.Windows.Forms.DataGridView gridStockIn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSubtotal;
        private System.Windows.Forms.Button btnExit;
    }
}

