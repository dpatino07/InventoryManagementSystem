namespace InventoryApplication
{
    partial class ModifyProduct
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
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partsAssociatedLabel = new System.Windows.Forms.Label();
            this.partsAssociatedDataGridView = new System.Windows.Forms.DataGridView();
            this.allPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.deletePartsBtn = new System.Windows.Forms.Button();
            this.addPartsBtn = new System.Windows.Forms.Button();
            this.modifyProductAppLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(727, 44);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(186, 20);
            this.productSearchBox.TabIndex = 55;
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(657, 43);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(64, 20);
            this.productSearchBtn.TabIndex = 54;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "All candidate Parts";
            // 
            // partsAssociatedLabel
            // 
            this.partsAssociatedLabel.AutoSize = true;
            this.partsAssociatedLabel.Location = new System.Drawing.Point(513, 306);
            this.partsAssociatedLabel.Name = "partsAssociatedLabel";
            this.partsAssociatedLabel.Size = new System.Drawing.Size(167, 13);
            this.partsAssociatedLabel.TabIndex = 52;
            this.partsAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // partsAssociatedDataGridView
            // 
            this.partsAssociatedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedDataGridView.Location = new System.Drawing.Point(513, 331);
            this.partsAssociatedDataGridView.Name = "partsAssociatedDataGridView";
            this.partsAssociatedDataGridView.Size = new System.Drawing.Size(400, 147);
            this.partsAssociatedDataGridView.TabIndex = 51;
            // 
            // allPartsDataGridView
            // 
            this.allPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsDataGridView.Location = new System.Drawing.Point(513, 89);
            this.allPartsDataGridView.Name = "allPartsDataGridView";
            this.allPartsDataGridView.Size = new System.Drawing.Size(400, 147);
            this.allPartsDataGridView.TabIndex = 50;
            // 
            // deletePartsBtn
            // 
            this.deletePartsBtn.Location = new System.Drawing.Point(855, 496);
            this.deletePartsBtn.Name = "deletePartsBtn";
            this.deletePartsBtn.Size = new System.Drawing.Size(58, 41);
            this.deletePartsBtn.TabIndex = 49;
            this.deletePartsBtn.Text = "Delete";
            this.deletePartsBtn.UseVisualStyleBackColor = true;
            this.deletePartsBtn.Click += new System.EventHandler(this.deletePartsBtn_Click);
            // 
            // addPartsBtn
            // 
            this.addPartsBtn.Location = new System.Drawing.Point(855, 256);
            this.addPartsBtn.Name = "addPartsBtn";
            this.addPartsBtn.Size = new System.Drawing.Size(58, 41);
            this.addPartsBtn.TabIndex = 48;
            this.addPartsBtn.Text = "Add";
            this.addPartsBtn.UseVisualStyleBackColor = true;
            this.addPartsBtn.Click += new System.EventHandler(this.addPartsBtn_Click);
            // 
            // modifyProductAppLabel
            // 
            this.modifyProductAppLabel.AutoSize = true;
            this.modifyProductAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductAppLabel.Location = new System.Drawing.Point(108, 30);
            this.modifyProductAppLabel.Name = "modifyProductAppLabel";
            this.modifyProductAppLabel.Size = new System.Drawing.Size(122, 18);
            this.modifyProductAppLabel.TabIndex = 47;
            this.modifyProductAppLabel.Text = "Modify Product";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(855, 559);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(58, 41);
            this.cancelBtn.TabIndex = 46;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(780, 559);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(58, 41);
            this.saveBtn.TabIndex = 45;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(134, 233);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 39;
            this.priceLabel.Text = "Price";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(316, 259);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 40;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(138, 259);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 41;
            this.maxLabel.Text = "Max";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(130, 181);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 42;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(114, 207);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 43;
            this.inventoryLabel.Text = "Inventory";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(147, 155);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 44;
            this.idLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(391, 256);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(68, 20);
            this.minTextBox.TabIndex = 33;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(213, 256);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(68, 20);
            this.maxTextBox.TabIndex = 34;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(213, 230);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 35;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(213, 204);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(213, 178);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 37;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(213, 152);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 38;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 640);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partsAssociatedLabel);
            this.Controls.Add(this.partsAssociatedDataGridView);
            this.Controls.Add(this.allPartsDataGridView);
            this.Controls.Add(this.deletePartsBtn);
            this.Controls.Add(this.addPartsBtn);
            this.Controls.Add(this.modifyProductAppLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button productSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partsAssociatedLabel;
        private System.Windows.Forms.DataGridView partsAssociatedDataGridView;
        private System.Windows.Forms.DataGridView allPartsDataGridView;
        private System.Windows.Forms.Button deletePartsBtn;
        private System.Windows.Forms.Button addPartsBtn;
        private System.Windows.Forms.Label modifyProductAppLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}