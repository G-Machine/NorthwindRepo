namespace Northwind.WebFormsUI
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxNewQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblNewQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxNewUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblNewUnitsInStock = new System.Windows.Forms.Label();
            this.tbxNewPrice = new System.Windows.Forms.TextBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.tbxNewProductName = new System.Windows.Forms.TextBox();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.cbxNewCategory = new System.Windows.Forms.ComboBox();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblUpdatePricce = new System.Windows.Forms.Label();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCategory.AutoSize = true;
            this.gbxCategory.Controls.Add(this.cbxCategorie);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(984, 77);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Suche Nach Kategori";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(144, 23);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(370, 21);
            this.cbxCategorie.TabIndex = 1;
            this.cbxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbxCategorie_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategorie:";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProduct.AutoSize = true;
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(12, 98);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(984, 77);
            this.gbxProduct.TabIndex = 1;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Suche Nach Produkt";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProductName.Location = new System.Drawing.Point(144, 26);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(370, 20);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(7, 33);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(73, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Produktname:";
            // 
            // dgwProduct
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.Location = new System.Drawing.Point(13, 185);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(984, 236);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxNewQuantityPerUnit);
            this.groupBox1.Controls.Add(this.lblNewQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxNewUnitsInStock);
            this.groupBox1.Controls.Add(this.lblNewUnitsInStock);
            this.groupBox1.Controls.Add(this.tbxNewPrice);
            this.groupBox1.Controls.Add(this.lblNewPrice);
            this.groupBox1.Controls.Add(this.tbxNewProductName);
            this.groupBox1.Controls.Add(this.lblNewProductName);
            this.groupBox1.Controls.Add(this.cbxNewCategory);
            this.groupBox1.Controls.Add(this.lblNewCategory);
            this.groupBox1.Location = new System.Drawing.Point(13, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neue Produkt";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(777, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Speichern";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxNewQuantityPerUnit
            // 
            this.tbxNewQuantityPerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewQuantityPerUnit.Location = new System.Drawing.Point(714, 51);
            this.tbxNewQuantityPerUnit.Name = "tbxNewQuantityPerUnit";
            this.tbxNewQuantityPerUnit.Size = new System.Drawing.Size(209, 20);
            this.tbxNewQuantityPerUnit.TabIndex = 11;
            // 
            // lblNewQuantityPerUnit
            // 
            this.lblNewQuantityPerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewQuantityPerUnit.AutoSize = true;
            this.lblNewQuantityPerUnit.Location = new System.Drawing.Point(619, 58);
            this.lblNewQuantityPerUnit.Name = "lblNewQuantityPerUnit";
            this.lblNewQuantityPerUnit.Size = new System.Drawing.Size(95, 13);
            this.lblNewQuantityPerUnit.TabIndex = 10;
            this.lblNewQuantityPerUnit.Text = "Anzahl pro Einheit:";
            // 
            // tbxNewUnitsInStock
            // 
            this.tbxNewUnitsInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewUnitsInStock.Location = new System.Drawing.Point(714, 23);
            this.tbxNewUnitsInStock.Name = "tbxNewUnitsInStock";
            this.tbxNewUnitsInStock.Size = new System.Drawing.Size(209, 20);
            this.tbxNewUnitsInStock.TabIndex = 9;
            // 
            // lblNewUnitsInStock
            // 
            this.lblNewUnitsInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewUnitsInStock.AutoSize = true;
            this.lblNewUnitsInStock.Location = new System.Drawing.Point(619, 30);
            this.lblNewUnitsInStock.Name = "lblNewUnitsInStock";
            this.lblNewUnitsInStock.Size = new System.Drawing.Size(69, 13);
            this.lblNewUnitsInStock.TabIndex = 8;
            this.lblNewUnitsInStock.Text = "Stockanzahl:";
            // 
            // tbxNewPrice
            // 
            this.tbxNewPrice.Location = new System.Drawing.Point(143, 82);
            this.tbxNewPrice.Name = "tbxNewPrice";
            this.tbxNewPrice.Size = new System.Drawing.Size(271, 20);
            this.tbxNewPrice.TabIndex = 7;
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(6, 89);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(33, 13);
            this.lblNewPrice.TabIndex = 6;
            this.lblNewPrice.Text = "Preis:";
            // 
            // tbxNewProductName
            // 
            this.tbxNewProductName.Location = new System.Drawing.Point(143, 19);
            this.tbxNewProductName.Name = "tbxNewProductName";
            this.tbxNewProductName.Size = new System.Drawing.Size(271, 20);
            this.tbxNewProductName.TabIndex = 5;
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(6, 26);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(73, 13);
            this.lblNewProductName.TabIndex = 4;
            this.lblNewProductName.Text = "Produktname:";
            // 
            // cbxNewCategory
            // 
            this.cbxNewCategory.FormattingEnabled = true;
            this.cbxNewCategory.Location = new System.Drawing.Point(143, 50);
            this.cbxNewCategory.Name = "cbxNewCategory";
            this.cbxNewCategory.Size = new System.Drawing.Size(271, 21);
            this.cbxNewCategory.TabIndex = 3;
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(6, 58);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(55, 13);
            this.lblNewCategory.TabIndex = 2;
            this.lblNewCategory.Text = "Kategorie:";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxUpdateProduct.AutoSize = true;
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.label1);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.label2);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdatePricce);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(12, 624);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(983, 121);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Aktualisiere Produkt";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(777, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Aktualisieren";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(714, 51);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(209, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anzahl pro Einheit:";
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(714, 23);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(209, 20);
            this.tbxUpdateUnitsInStock.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stockanzahl:";
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(143, 82);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(271, 20);
            this.tbxUpdatePrice.TabIndex = 7;
            // 
            // lblUpdatePricce
            // 
            this.lblUpdatePricce.AutoSize = true;
            this.lblUpdatePricce.Location = new System.Drawing.Point(6, 89);
            this.lblUpdatePricce.Name = "lblUpdatePricce";
            this.lblUpdatePricce.Size = new System.Drawing.Size(33, 13);
            this.lblUpdatePricce.TabIndex = 6;
            this.lblUpdatePricce.Text = "Preis:";
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(143, 19);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(271, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Location = new System.Drawing.Point(6, 26);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(73, 13);
            this.lblUpdateProduct.TabIndex = 4;
            this.lblUpdateProduct.Text = "Produktname:";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(143, 50);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(271, 21);
            this.cbxUpdateCategory.TabIndex = 3;
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(6, 58);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateCategory.TabIndex = 2;
            this.lblUpdateCategory.Text = "Kategorie:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(891, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.MaximumSize = new System.Drawing.Size(1024, 800);
            this.MinimumSize = new System.Drawing.Size(1024, 800);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNewProductName;
        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.ComboBox cbxNewCategory;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxNewQuantityPerUnit;
        private System.Windows.Forms.Label lblNewQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxNewUnitsInStock;
        private System.Windows.Forms.Label lblNewUnitsInStock;
        private System.Windows.Forms.TextBox tbxNewPrice;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.Label lblUpdatePricce;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Button btnDelete;
    }
}

