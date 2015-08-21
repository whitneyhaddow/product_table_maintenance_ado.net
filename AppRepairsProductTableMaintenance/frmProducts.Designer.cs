namespace AppRepairsProductTableMaintenance
{
    partial class frmProducts
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtYearsWarranty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.cboProductCodes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(222, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Product Code:";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(170, 132);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.ReadOnly = true;
            this.txtReleaseDate.Size = new System.Drawing.Size(281, 20);
            this.txtReleaseDate.TabIndex = 51;
            this.txtReleaseDate.Tag = "Release Date";
            // 
            // txtYearsWarranty
            // 
            this.txtYearsWarranty.Location = new System.Drawing.Point(170, 101);
            this.txtYearsWarranty.Name = "txtYearsWarranty";
            this.txtYearsWarranty.ReadOnly = true;
            this.txtYearsWarranty.Size = new System.Drawing.Size(281, 20);
            this.txtYearsWarranty.TabIndex = 50;
            this.txtYearsWarranty.Tag = "Years of Warranty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Release Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Years of Warranty:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 69);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.TabIndex = 47;
            this.txtName.Tag = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Name:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(357, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(122, 177);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(357, 30);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(94, 25);
            this.btnGetProduct.TabIndex = 1;
            this.btnGetProduct.Text = "&Find Product";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // cboProductCodes
            // 
            this.cboProductCodes.FormattingEnabled = true;
            this.cboProductCodes.Location = new System.Drawing.Point(170, 33);
            this.cboProductCodes.Name = "cboProductCodes";
            this.cboProductCodes.Size = new System.Drawing.Size(170, 21);
            this.cboProductCodes.TabIndex = 0;
            this.cboProductCodes.Tag = "Product Code";
            // 
            // frmProducts
            // 
            this.AcceptButton = this.btnGetProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(480, 226);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtYearsWarranty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetProduct);
            this.Controls.Add(this.cboProductCodes);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.TextBox txtYearsWarranty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.ComboBox cboProductCodes;
    }
}

