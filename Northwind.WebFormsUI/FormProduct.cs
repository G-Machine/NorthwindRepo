using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolves.Ninject;
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
    public partial class FormProduct : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public FormProduct()
        {
            InitializeComponent();

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategorie.DataSource = _categoryService.GetAll();
            cbxCategorie.DisplayMember = "CategoryName";
            cbxCategorie.ValueMember = "CategoryId";

            //By Add Category
            cbxNewCategory.DataSource = _categoryService.GetAll();
            cbxNewCategory.DisplayMember = "CategoryName";
            cbxNewCategory.ValueMember = "CategoryId";

            //By Update Category
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";

        }

        private void cbxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory((int)cbxCategorie.SelectedValue);
            }
            catch (Exception)
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

            var searchKey = tbxProductName.Text;
            if (!string.IsNullOrEmpty(searchKey))
                ProductSearchByName(searchKey);
            else
                LoadProducts();
        }

        private void ProductSearchByName(string searchKey)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByProductName(searchKey);
            }
            catch (Exception)
            {
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdatePrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = (int)dgwProduct.CurrentRow.Cells[0].Value,
                    CategoryId = (int)cbxUpdateCategory.SelectedValue,
                    ProductName = tbxUpdateProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdatePrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text

                });
                MessageBox.Show("Das Produkt wurde aktualisiert");
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = (int)cbxNewCategory.SelectedValue,
                    ProductName = tbxNewProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxNewPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxNewUnitsInStock.Text),
                    QuantityPerUnit = tbxNewQuantityPerUnit.Text
                });
                MessageBox.Show("Das Produkt wurde gespeichert");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = (int)dgwProduct.CurrentRow.Cells[0].Value
                    });
                    MessageBox.Show("Produkt Gelöscht!");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
