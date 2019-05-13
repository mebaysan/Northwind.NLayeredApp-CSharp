using Northwind.Bussiness.Abstract;
using Northwind.Bussiness.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName"; // combobox'ta category name görünecek
            cbxCategory.ValueMember = "CategoryId";     // fakat seçilince bize değer olarak categoryid dönecek

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProducts() // ürünleri getireceğimiz method
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {

            }

        }

        private void TbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text)) // eğer tbxproductname.text boş değilse bu bloğu çalıştır
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductName.Text);
            }
            else // değilse loadproducts methodu çalıştır.
            {
                LoadProducts();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                ProductName = tbxProductName2.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxStock.Text)

            });
            MessageBox.Show("Ürün kaydedildi!");
            LoadProducts();
        }
    }
}
