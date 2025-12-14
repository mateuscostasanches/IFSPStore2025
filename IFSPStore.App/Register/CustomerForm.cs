
using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{
    public partial class CustomerForm : BaseForm
    {
        #region Variables
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<City> _cityService;
        private List<CustomerViewModel>? customers;
        #endregion

        #region Constructor
        public CustomerForm(IBaseService<Customer> custumerService, IBaseService<City> cityService)
        {
            _customerService = custumerService;
            _cityService = cityService;
            InitializeComponent();
            LoadCombo();
        }
        #endregion

        #region Methods
        private void LoadCombo()
        {
            txtCityState.ValueMember = "Id";
            txtCityState.DisplayMember = "CityState";
            txtCityState.DataSource = _cityService.Get<CityViewModel>().ToList();
        }

        private void FormToObject(Customer customer)
        {
            customer.Name = txtName.Text;
            customer.Address = txtCityState.Text;
            customer.Document = txtDocument.Text;
            customer.District = txtDistrict.Text;

            if (int.TryParse(txtCityState.SelectedValue!.ToString(), out var idGroup))
            {
                var city = _cityService.GetById<City>(idGroup);
                customer.City = city;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var customer = _customerService.GetById<Customer>(id);
                    FormToObject(customer);
                    customer = _customerService.Update<Customer, Customer, CustomerValidator>(customer);
                }
                else
                {
                    var customer = new Customer();
                    FormToObject(customer);
                    _customerService.Add<Customer, Customer, CustomerValidator>(customer);
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
                _customerService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string>() { "City" };
            customers = _customerService.Get<CustomerViewModel>(includes).ToList();
            dataGridViewList.DataSource = customers;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Document"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Document"]!.DefaultCellStyle!.Format = "000\\.000\\.000-00";
            dataGridViewList.Columns["CityState"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CityState"]!.HeaderText = "City - State";
            dataGridViewList.Columns["District"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CityId"]!.Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record!.Cells["Id"].Value.ToString();
            txtName.Text = record!.Cells["Name"].Value.ToString();
            txtDocument.Text = record!.Cells["Document"].Value.ToString();
            txtCityState.Text = record!.Cells["CityState"].Value.ToString();
            txtCityState.SelectedValue = record!.Cells["CityId"].Value.ToString();
            txtDistrict.Text = record!.Cells["District"].Value.ToString();
        }
        #endregion

        #region Events
        private void CustomerForm_Load(object sender, EventArgs e)  
        {
            LoadCombo();
            txtCityState.SelectedIndex = -1;
            ClearFields();
        }
        #endregion 

    }

}
