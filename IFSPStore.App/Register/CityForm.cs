
using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{
    public partial class CityForm : BaseForm
    {

        #region Variables
        private readonly IBaseService<City> _cityService;
        private List<CityViewModel>? cities;
        #endregion

        #region Constructor
        public CityForm(IBaseService<City> cityService)
        {
            _cityService = cityService;
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void FormToObject(City city)
        {
            city.Name = txtName.Text;
            city.State = txtState.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var city = _cityService.GetById<City>(id);
                    FormToObject(city);
                    city = _cityService.Update<City, City, CityValidator>(city);
                }

                else
                {
                    var city = new City();
                    FormToObject(city);
                    _cityService.Add<City, City, CityValidator>(city);
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
                _cityService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            cities = _cityService.Get<CityViewModel>().ToList();
            dataGridViewList.DataSource = cities;
            dataGridViewList.Columns["Id"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["State"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["CityState"]!.Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtState.Text = record?.Cells["State"].Value.ToString();
        }
        #endregion

        #region Events
        private void CityForm_Load(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion 

    }

}
