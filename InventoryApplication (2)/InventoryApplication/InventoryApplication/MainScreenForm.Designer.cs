namespace InventoryApplication
{
    partial class MainScreenForm
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
            this.addProductsBtn = new System.Windows.Forms.Button();
            this.modifyProductsBtn = new System.Windows.Forms.Button();
            this.deleteProductsBtn = new System.Windows.Forms.Button();
            this.addPartsBtn = new System.Windows.Forms.Button();
            this.modifyPartsBtn = new System.Windows.Forms.Button();
            this.deletePartsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.partSearchBtn = new System.Windows.Forms.Button();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.inventoryMgmtSysAppLabel = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductsBtn
            // 
            this.addProductsBtn.Location = new System.Drawing.Point(811, 302);
            this.addProductsBtn.Name = "addProductsBtn";
            this.addProductsBtn.Size = new System.Drawing.Size(58, 41);
            this.addProductsBtn.TabIndex = 0;
            this.addProductsBtn.Text = "Add";
            this.addProductsBtn.UseVisualStyleBackColor = true;
            this.addProductsBtn.Click += new System.EventHandler(this.addProductsBtn_Click);
            // 
            // modifyProductsBtn
            // 
            this.modifyProductsBtn.Location = new System.Drawing.Point(890, 302);
            this.modifyProductsBtn.Name = "modifyProductsBtn";
            this.modifyProductsBtn.Size = new System.Drawing.Size(58, 41);
            this.modifyProductsBtn.TabIndex = 0;
            this.modifyProductsBtn.Text = "Modify";
            this.modifyProductsBtn.UseVisualStyleBackColor = true;
            this.modifyProductsBtn.Click += new System.EventHandler(this.modifyProductsBtn_Click);
            // 
            // deleteProductsBtn
            // 
            this.deleteProductsBtn.Location = new System.Drawing.Point(968, 302);
            this.deleteProductsBtn.Name = "deleteProductsBtn";
            this.deleteProductsBtn.Size = new System.Drawing.Size(58, 41);
            this.deleteProductsBtn.TabIndex = 0;
            this.deleteProductsBtn.Text = "Delete";
            this.deleteProductsBtn.UseVisualStyleBackColor = true;
            this.deleteProductsBtn.Click += new System.EventHandler(this.deleteProductsBtn_Click);
            // 
            // addPartsBtn
            // 
            this.addPartsBtn.Location = new System.Drawing.Point(269, 302);
            this.addPartsBtn.Name = "addPartsBtn";
            this.addPartsBtn.Size = new System.Drawing.Size(58, 41);
            this.addPartsBtn.TabIndex = 0;
            this.addPartsBtn.Text = "Add";
            this.addPartsBtn.UseVisualStyleBackColor = true;
            this.addPartsBtn.Click += new System.EventHandler(this.addPartsBtn_Click);
            // 
            // modifyPartsBtn
            // 
            this.modifyPartsBtn.Location = new System.Drawing.Point(348, 302);
            this.modifyPartsBtn.Name = "modifyPartsBtn";
            this.modifyPartsBtn.Size = new System.Drawing.Size(58, 41);
            this.modifyPartsBtn.TabIndex = 0;
            this.modifyPartsBtn.Text = "Modify";
            this.modifyPartsBtn.UseVisualStyleBackColor = true;
            this.modifyPartsBtn.Click += new System.EventHandler(this.modifyPartsBtn_Click);
            // 
            // deletePartsBtn
            // 
            this.deletePartsBtn.Location = new System.Drawing.Point(426, 302);
            this.deletePartsBtn.Name = "deletePartsBtn";
            this.deletePartsBtn.Size = new System.Drawing.Size(58, 41);
            this.deletePartsBtn.TabIndex = 0;
            this.deletePartsBtn.Text = "Delete";
            this.deletePartsBtn.UseVisualStyleBackColor = true;
            this.deletePartsBtn.Click += new System.EventHandler(this.deletePartsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(968, 413);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(58, 41);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // partSearchBtn
            // 
            this.partSearchBtn.Location = new System.Drawing.Point(263, 90);
            this.partSearchBtn.Name = "partSearchBtn";
            this.partSearchBtn.Size = new System.Drawing.Size(64, 20);
            this.partSearchBtn.TabIndex = 2;
            this.partSearchBtn.Text = "Search";
            this.partSearchBtn.UseVisualStyleBackColor = true;
            this.partSearchBtn.Click += new System.EventHandler(this.partSearchBtn_Click);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(805, 90);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(64, 20);
            this.productSearchBtn.TabIndex = 2;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(334, 90);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(150, 20);
            this.partSearchBox.TabIndex = 3;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(876, 90);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(150, 20);
            this.productSearchBox.TabIndex = 3;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(102, 90);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(39, 16);
            this.partsLabel.TabIndex = 4;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(644, 90);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(61, 16);
            this.productsLabel.TabIndex = 4;
            this.productsLabel.Text = "Products";
            // 
            // inventoryMgmtSysAppLabel
            // 
            this.inventoryMgmtSysAppLabel.AutoSize = true;
            this.inventoryMgmtSysAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryMgmtSysAppLabel.Location = new System.Drawing.Point(69, 28);
            this.inventoryMgmtSysAppLabel.Name = "inventoryMgmtSysAppLabel";
            this.inventoryMgmtSysAppLabel.Size = new System.Drawing.Size(238, 18);
            this.inventoryMgmtSysAppLabel.TabIndex = 5;
            this.inventoryMgmtSysAppLabel.Text = "Inventory Management System";
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(105, 116);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.Size = new System.Drawing.Size(379, 170);
            this.partsDataGridView.TabIndex = 6;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(647, 116);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(379, 170);
            this.productsDataGridView.TabIndex = 7;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 570);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.inventoryMgmtSysAppLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.partSearchBtn);
            this.Controls.Add(this.deletePartsBtn);
            this.Controls.Add(this.modifyPartsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteProductsBtn);
            this.Controls.Add(this.addPartsBtn);
            this.Controls.Add(this.modifyProductsBtn);
            this.Controls.Add(this.addProductsBtn);
            this.Name = "MainScreenForm";
            this.Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductsBtn;
        private System.Windows.Forms.Button modifyProductsBtn;
        private System.Windows.Forms.Button deleteProductsBtn;
        private System.Windows.Forms.Button addPartsBtn;
        private System.Windows.Forms.Button modifyPartsBtn;
        private System.Windows.Forms.Button deletePartsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button partSearchBtn;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label inventoryMgmtSysAppLabel;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}