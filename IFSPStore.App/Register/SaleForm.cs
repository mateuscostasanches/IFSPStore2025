
using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using System.Globalization;

namespace IFSPStore.App.Register
{

    public partial class SaleForm : BaseForm
    {

        #region Variables
        private List<SaleItemViewModel> _saleItems;
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<Product> _productService;
        private List<SaleViewModel>? sales;
        #endregion

        #region Constructor
        public SaleForm(IBaseService<Sale> saleService, IBaseService<User> userService,
                        IBaseService<Customer> customerService, IBaseService<Product> productService)
        {
            _saleService = saleService;
            _userService = userService;
            _customerService = customerService;
            _productService = productService;
            _saleItems = new List<SaleItemViewModel>();

            InitializeComponent();
            LoadCombo();
            PopulateGridItemsSale();
        }
        #endregion

        #region Methods
        private void LoadCombo()
        {

            txtUser.ValueMember = "Id";
            txtUser.DisplayMember = "Name";
            txtUser.DataSource = _userService.Get<User>().ToList();

            txtCustomer.ValueMember = "Id";
            txtCustomer.DisplayMember = "Name";
            txtCustomer.DataSource = _customerService.Get<Customer>().ToList();

            txtProduct.ValueMember = "Id";
            txtProduct.DisplayMember = "Name";
            txtProduct.DataSource = _productService.Get<Product>().ToList();

        }

        private void FormToObject(Sale sale)
        {
            sale.SaleDate = DateTime.Now.Date;

            if (int.TryParse(txtUser.SelectedValue!.ToString(), out var idUser))
            {
                var user = _userService.GetById<User>(idUser);
                sale.Salesman = user;
            }

            if (int.TryParse(txtCustomer.SelectedValue!.ToString(), out var idCustomer))
            {
                var customer = _customerService.GetById<Customer>(idCustomer);
                sale.Customer = customer;
            }
            sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);

            foreach (var item in _saleItems)
            {
                var itemSale = new SaleItem
                {
                    Sale = sale,
                    Product = _productService.GetById<Product>(item.ProductId),
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    TotalPrice = item.TotalPrice
                };

                sale.SaleItems.Add(itemSale);
            }

        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            PopulateGridItemsSale();
            CalcTotalSale();
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        FormToObject(sale);
                        sale = _saleService.Update<Sale, Sale, SaleValidator>(sale);
                    }
                }
                else
                {
                    var sale = new Sale();
                    FormToObject(sale);
                    sale = _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }

                tabControlRegister.SelectedIndex = 1;
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
                _saleService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string>() { "Customer", "Salesman" };
            sales = _saleService.Get<SaleViewModel>(includes).ToList();
            dataGridViewList.DataSource = sales;
            dataGridViewList.Columns["UserId"]!.Visible = false;
            dataGridViewList.Columns["CustomerId"]!.Visible = false;
            dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Format = "C2";
            dataGridViewList.Columns["SaleTotal"].HeaderText = "Total Sale";
            dataGridViewList.Columns["SaleDate"].HeaderText = "Sale Date";
            dataGridViewList.Columns["SaleTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["SaleDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Customer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            int.TryParse(record?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtUser.SelectedValue = record?.Cells["UserId"].Value;
            txtCustomer.SelectedValue = record?.Cells["CustomerId"].Value;
            DateTime.Parse(record?.Cells["SaleDate"].Value.ToString());

            var includes = new List<string>() { "Customer", "Salesman", "SaleItems", "SaleItems .Product" };
            var sale = _saleService.GetById<Sale>(id, includes);
            _saleItems = new List<SaleItemViewModel>();
            foreach (var item in sale.SaleItems)
            {
                var saleItem = new SaleItemViewModel
                {
                    Id = item.Id,
                    ProductId = item.Product!.Id,
                    Product = item.Product!.Name,
                    TotalPrice = item.TotalPrice,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };
                _saleItems.Add(saleItem);
            }
            PopulateGridItemsSale();

        }

        private void PopulateGridItemsSale()
        {
            var source = new BindingSource();
            source.DataSource = _saleItems.ToArray();
            dataGridViewSaleItems.DataSource = source;
            dataGridViewSaleItems.Columns["Id"]!.Visible = false;
            dataGridViewSaleItems.Columns["Sale"]!.Visible = false;
            dataGridViewSaleItems.Columns["ProductId"]!.HeaderText = @"Id Product";
            dataGridViewSaleItems.Columns["ProductId"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSaleItems.Columns["UnitPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewSaleItems.Columns["UnitPrice"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSaleItems.Columns["UnitPrice"]!.HeaderText = "Unit Price";
            dataGridViewSaleItems.Columns["TotalPrice"]!.DefaultCellStyle.Format = "C2";
            dataGridViewSaleItems.Columns["TotalPrice"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSaleItems.Columns["TotalPrice"]!.HeaderText = "Total Price";
            dataGridViewSaleItems.Columns["Quantity"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSaleItems.Columns["Product"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private bool ItemValidation()
        {
            return true;
        }

        private void CalcTotalItems()
        {
            var convVlr = float.TryParse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float UnitValue);
            var convQtd = int.TryParse(txtQuantity.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * UnitValue;
                txtTotalPrice.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalcTotalSale()
        {
            lblValue.Text = $@"Total Value: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _saleItems.Sum(x => x.TotalPrice))}";
            lblQuantityItems.Text = $@"Products: {_saleItems.Sum(x => x.Quantity)}";
        }
        #endregion

        #region Events
        private void txtUnitValue_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtUnitPrice.Text, out double value))
                txtUnitPrice.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                txtUnitPrice.Text = string.Empty;

            CalcTotalItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ItemValidation())
            {
                var saleItem = new SaleItemViewModel();
                if (int.TryParse(txtProduct.SelectedValue.ToString(), out var idProduct))
                {
                    var product = _productService.GetById<Product>(idProduct);
                    saleItem.ProductId = product.Id;
                    saleItem.Product = product.Name;
                }

                if (decimal.TryParse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var UnitValue))
                {
                    saleItem.UnitPrice = UnitValue;
                }
                if (int.TryParse(txtQuantity.Text, out var qtd))
                {
                    saleItem.Quantity = qtd;
                }

                saleItem.TotalPrice = saleItem.Quantity * saleItem.UnitPrice;

                _saleItems.Add(saleItem);
                CalcTotalSale();
                PopulateGridItemsSale();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewSaleItems.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSaleItems.SelectedRows[0];
                if (int.TryParse(selectedRow.Cells["ProductId"].Value?.ToString(), out var idProductToRemove))
                {
                    var itemToRemove = _saleItems.FirstOrDefault(item => item.ProductId == idProductToRemove);

                    if (itemToRemove != null)
                    {
                        _saleItems.Remove(itemToRemove);
                        CalcTotalSale();
                        PopulateGridItemsSale();
                    }
                }
                else
                {
                    MessageBox.Show("Could not identify the selected product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a product in the table to remove.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalcTotalItems();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadCombo();
            txtProduct.SelectedIndex = -1;
            txtUser.SelectedIndex = -1;
            txtCustomer.SelectedIndex = -1;
            ClearFields();
        }
        
        private void txtProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtProduct.SelectedValue != null && int.TryParse(txtProduct.SelectedValue.ToString(), out var idProduct))
            {
                var product = _productService.GetById<Product>(idProduct);

                if (product != null)
                {
                    txtUnitPrice.Text = string.Format(
                        CultureInfo.CurrentCulture,
                        "{0:C2}",
                        product.Price
                    );
                    txtQuantity.Text = "1";
                    CalcTotalItems();
                }
            }
        }
        #endregion

    }

}
