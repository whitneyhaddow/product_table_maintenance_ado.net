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

//This form allows maintenance of the Product table in the Appliance Maintenance Database.
namespace AppRepairsProductTableMaintenance
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        Product product; 

        //LOAD COMBO BOX ON FORM LOAD
        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                this.FillComboBox();
                cboProductCodes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            btnEdit.Enabled = false; //disable edit button when no product selected
            btnDelete.Enabled = false;
        }


        //FILL COMBO BOX
        private void FillComboBox()
        {
            List<string> productCodes = ProductDB.GetProductCodes(); //get list of codes from DB

            cboProductCodes.Items.Clear();

            //load list into cbo box
            for (int i = 0; i < productCodes.Count; i++)
            {
                cboProductCodes.Items.Add(productCodes[i]);
            }
        }


        //GET PRODUCT SELECTED BY COMBO BOX
        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            string productCode = cboProductCodes.Text;
            this.GetProduct(productCode);
        }

        //GET PRODUCT FROM DB BY PRODUCT CODE
        private void GetProduct(string productID)
        {
            try
            {
                product = ProductDB.GetProduct(productID);

                if (product == null)
                    MessageBox.Show("No product found with this product code.", "Product Not Found");
                else
                    this.ShowProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        //DISPLAY PRODUCT INFO
        private void ShowProduct()
        {
            txtName.Text = product.ProductName;
            txtReleaseDate.Text = product.ReleaseDate.ToString("yyyy-MM-dd");
            txtYearsWarranty.Text = product.YearsWarranty.ToString();
            btnEdit.Enabled = true; //enable editing
            btnDelete.Enabled = true;
        }


        //ADD NEW PRODUCT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProduct addForm = new frmAddEditProduct(); 
            addForm.addProduct = true;

            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                product = addForm.product;
                this.FillComboBox();
                cboProductCodes.Text = product.ProductCode;
                this.ShowProduct();
            }
        }

        //EDIT CURRENT PRODUCT
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProduct editForm = new frmAddEditProduct();
            editForm.addProduct = false; //editing
            editForm.product = product; //use current product to pass data to product in editing form
            DialogResult result = editForm.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                product = editForm.product; //new current product equal to edits made in editForm
                this.FillComboBox();
                cboProductCodes.Text = product.ProductCode;
                this.ShowProduct(); 
            }
            else if (result == DialogResult.Retry) //retry due to concurrency error
            {
                this.ClearControls();
                this.GetProduct(product.ProductCode); //re-get product based on product code 
            }
        }


        //CLEAR CONTROLS 
        private void ClearControls()
        {
            txtName.Text = "";
            txtYearsWarranty.Text = "";
            txtReleaseDate.Text = "";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        //DELETE CURRENT PRODUCT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Press OK to delete "
                                    + product.ProductCode.ToString(), "Confirm Deletion",
                                    MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ProductDB.DeleteProduct(product);
                this.FillComboBox();
                cboProductCodes.SelectedIndex = 0;
                this.ClearControls();
            }
        }


        //CLOSE FORM
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//END CLASS
}
