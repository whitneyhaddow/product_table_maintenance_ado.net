using ProductsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This form allows user to either add a new product, or edit an existing one.
namespace AppRepairsProductTableMaintenance
{
    public partial class frmAddEditProduct : Form
    {
        public frmAddEditProduct()
        {
            InitializeComponent();
        }

        public bool addProduct; //editing(false) or adding(true)
        public Product product;

        //DETERMINE ADDING OR EDITING ON FORM LOAD
        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            if (addProduct)
            {
                this.Text = "Add Product";
            }
            else //edit product
            {
                this.Text = "Edit Product";
                DisplayProductData(); //fill text fields
            }
        }


        //DISPLAY EXISTING DATA FOR EDIT
        private void DisplayProductData()
        {
            txtProductCode.Text = product.ProductCode;
            txtName.Text = product.ProductName;
            txtYearsWarranty.Text = product.YearsWarranty.ToString();
            txtReleaseDate.Text = product.ReleaseDate.ToString("yyyy-MM-dd");
        }


        //SAVE CHANGES
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addProduct)
                {
                    product = new Product(); //product being added
                    this.SaveToProduct(product);
                    try
                    {
                        ProductDB.AddProduct(product); //save product to DB
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else //edit product
                {
                    Product newProduct = new Product(); //updated product
                    this.SaveToProduct(newProduct);
                    try
                    {
                        if (!ProductDB.UpdateProduct(product, newProduct)) //if bool is false (concurrency error)
                        {
                            MessageBox.Show("Another user has updated or deleted that product.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else //bool is true, no concurrency issue
                        {
                            product = newProduct;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }


        //SAVE TEXTBOX TEXT TO A PRODUCT
        private void SaveToProduct(Product product)
        {
            product.ProductCode = txtProductCode.Text.ToUpper();
            product.ProductName = txtName.Text;
            product.YearsWarranty = Convert.ToDecimal(txtYearsWarranty.Text);
            product.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        }


        //VALIDATE INPUTS
        private bool IsValidData()
        {
            return Validator.IsPresent(txtProductCode) &&
                    Validator.IsPresent(txtName) &&
                    Validator.IsPresent(txtYearsWarranty) &&
                    Validator.IsInt(txtYearsWarranty) &&
                    Validator.IsPresent(txtReleaseDate) &&
                    Validator.IsDateTime(txtReleaseDate);
        }
        
    }//END CLASS
}
