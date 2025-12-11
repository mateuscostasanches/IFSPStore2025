
using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

namespace IFSPStore.App.Register
{
    public partial class ProductForm : BaseForm
    {

        #region Variables
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Category> _categoryService;
        private List<ProductViewModel>? products;
        #endregion 

        #region Constructor
        public ProductForm(IBaseService<Product> productService, IBaseService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void LoadCombo()
        {
            txtCategory.ValueMember = "Id";
            txtCategory.DisplayMember = "Name";
            txtCategory.DataSource = _categoryService.Get<CategoryViewModel>().ToList();
        }

        private void FormToObject(Product product)
        {
            product.Name = txtName.Text;
            product.PurchaseDate = DateTime.Today.Date;
            product.SalesUnit = txtSalesUnit.Text;

            if (Decimal.TryParse(txtPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price))
            {
                product.Price = price;
            }

            if (int.TryParse(txtCategory.SelectedValue!.ToString(), out var idGroup))
            {
                var category = _categoryService.GetById<Category>(idGroup);
                product.Category = category;
            }

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var product = _productService.GetById<Product>(id);
                    FormToObject(product);
                    product = _productService.Update<Product, Product, ProductValidator>(product);
                }
                else
                {
                    var product = new Product();
                    FormToObject(product);
                    _productService.Add<Product, Product, ProductValidator>(product);
                }
                tabControlRegister.SelectedIndex = 1;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _productService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string> { "Category" };
            products = _productService.Get<ProductViewModel>(includes).ToList();
            dataGridViewList.DataSource = products;
            dataGridViewList.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Category"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CategoryId"]!.Visible = false;
            dataGridViewList.Columns["Price"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["SalesUnit"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["SalesUnit"]!.HeaderText = "Sales Unit";
            dataGridViewList.Columns["PurchaseDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["PurchaseDate"]!.HeaderText = "Purchase Date";
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record!.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtPrice.Text = record.Cells["Price"].Value.ToString();
            txtSalesUnit.Text = record.Cells["SalesUnit"].Value.ToString();
            txtCategory.Text = record.Cells["CategoryId"].Value.ToString();
            record.Cells["PurchaseDate"].Value.ToString();
        }
        #endregion

        #region Events
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out double value))
                txtPrice.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtPrice.Text = string.Empty;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
            ClearFields();
        }
        #endregion
    }

}
