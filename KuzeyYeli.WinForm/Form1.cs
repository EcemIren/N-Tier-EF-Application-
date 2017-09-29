using KuzeyYeli.WinForm.CategoryServiceReference;
using KuzeyYeli.WinForm.ProductServiceReference;
using KuzeyYeli.WinForm.SupplierServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeli.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceOf_ProductDTOClient clientProduct = new ServiceOf_ProductDTOClient();
        ServiceOf_CategoryDTOClient clientCategory = new ServiceOf_CategoryDTOClient();
        ServiceOf_SupplierDTOClient clientSupplier = new ServiceOf_SupplierDTOClient();

        private void Form1_Load(object sender, EventArgs e)
        {    
            cmbCategory.DisplayMember = "KategoriAdi";
            cmbCategory.ValueMember = "KategoriID";

            cmbSupplier.DisplayMember = "SirketAdi";
            cmbSupplier.ValueMember = "TedarikciID";

            cmbCategory.DataSource =  clientCategory.List();
            cmbSupplier.DataSource = clientSupplier.List();

            dataGridView1.DataSource = clientProduct.List();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KuzeyYeliDTO.ProductDTO product = new KuzeyYeliDTO.ProductDTO();
            decimal d;

            if (txtProduct.Text == "")
            {
                product.UrunAdi = null;
            }

            else
            {
                product.UrunAdi = txtProduct.Text;
            }

            if(decimal.TryParse(nudCost.Text,out d))
            {
                product.Fiyat = d;
            }

            else
            {
                product.Fiyat = null;
            }

            if (txtDemand.Text == "")
            {
                product.BirimdekiMiktar = null;
            }

            else
            {
                product.BirimdekiMiktar = txtDemand.Text;
            }

            product.KategoriID = (int)cmbCategory.SelectedValue;
            product.TedarikciID = (int) cmbSupplier.SelectedValue;

            ValidationContext context = new ValidationContext(product, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            

            string message = "";
            if (!Validator.TryValidateObject(product, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    message = message + result+"\n";
                }
                MessageBox.Show(message);
            }
            else
            {
                clientProduct.Insert(product);
                dataGridView1.DataSource = clientProduct.List();
                MessageBox.Show("Validated, product is inserted to the database");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KuzeyYeliDTO.ProductDTO product = new KuzeyYeliDTO.ProductDTO();

            if (dataGridView1.CurrentRow!=null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
                product.UrunID = id;
                clientProduct.Delete(product);
                dataGridView1.DataSource = clientProduct.List();
                MessageBox.Show("Product is deleted from database");
            }
        }
    }
    }

