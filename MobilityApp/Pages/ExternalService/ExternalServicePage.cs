using Mobility.Data.Context;
using Mobility.Data.Models;
using MobilityApp.ViewModels;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MobilityApp.Pages.ExternalService
{
    public partial class ExternalServicePage : Form
    {
        private string apiUrl = "https://localhost:7054/api/Employee/";
        public ExternalServicePage()
        {
            InitializeComponent();
        }
        BindingSource bindingSource = new BindingSource();
        EmployeeViewModel selectedEmployee;
        int rowIndex = 0;

        private async void Create_Click(object sender, EventArgs e)
        {
            try
            {
                string url = apiUrl + "Create";

                var employee = new EmployeeViewModel()
                {
                    FirstName = FirstName.Text,
                    MailAddress = MailAddress.Text,
                    LastName = LastName.Text,
                    Salary = decimal.Parse(Salary.Text)
                };
                var id = await CreateOrUpdateEmployee(employee, true);
                employee.Id = id;
                bindingSource.Add(employee);
                EmployeesGrid.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null && string.IsNullOrWhiteSpace(Id.Text))
                {
                    MessageBox.Show("Chosse a person or fill the Id input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (MobilityContext context = new MobilityContext())
                {

                    selectedEmployee.FirstName = FirstName.Text;
                    selectedEmployee.MailAddress = MailAddress.Text;
                    selectedEmployee.LastName = LastName.Text;
                    selectedEmployee.Salary = decimal.Parse(Salary.Text);
                    selectedEmployee.Id = int.Parse(Id.Text);
                    await CreateOrUpdateEmployee(selectedEmployee, false);

                    var oldIndex = (EmployeeViewModel)bindingSource[rowIndex];
                    oldIndex.FirstName = selectedEmployee.FirstName;
                    oldIndex.LastName = selectedEmployee.LastName;
                    oldIndex.MailAddress = selectedEmployee.MailAddress;
                    oldIndex.Salary = selectedEmployee.Salary;
                    bindingSource.ResetItem(rowIndex);
                    EmployeesGrid.Refresh();
                }
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null && string.IsNullOrWhiteSpace(Id.Text))
                    MessageBox.Show("Chosse a person or fill the Id input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (selectedEmployee != null)
                {
                    await DeleteEmployee(int.Parse(Id.Text));

                    MessageBox.Show("Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSource.Remove(selectedEmployee);
                    EmployeesGrid.Refresh();
                }
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEmployee = (EmployeeViewModel)bindingSource[e.RowIndex];

            FirstName.Text = selectedEmployee.FirstName;
            LastName.Text = selectedEmployee.LastName;
            MailAddress.Text = selectedEmployee.MailAddress;
            Salary.Text = selectedEmployee.Salary.ToString();
            Id.Text = selectedEmployee.Id.ToString();
        }

        private async void ExternalServicePage_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var createUrl = apiUrl + "GetAll";

                    HttpResponseMessage response = await client.GetAsync(createUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        var employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(responseContent);
                        bindingSource.DataSource = employees;
                        EmployeesGrid.DataSource = bindingSource;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
            }
        }


        private async Task<int> CreateOrUpdateEmployee(EmployeeViewModel employee, bool isCreate)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response;

                    if (isCreate)
                    {
                        string url = apiUrl + "Create";
                        HttpRequestMessage requestMessage = new HttpRequestMessage();
                        requestMessage.Content = JsonContent.Create(employee);
                        requestMessage.Method = HttpMethod.Post;
                        client.BaseAddress = new Uri(url);
                        response = await client.SendAsync(requestMessage);
                        string responseContent = await response.Content.ReadAsStringAsync();
                        if (int.TryParse(responseContent, out var id))
                            return id;
                    }
                    else
                    {
                        string url = apiUrl + "Update/" + employee.Id;
                        HttpRequestMessage requestMessage = new HttpRequestMessage();
                        requestMessage.Content = JsonContent.Create(employee);
                        client.BaseAddress = new Uri(url);
                        requestMessage.Method = HttpMethod.Put;
                        await client.SendAsync(requestMessage);
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                    throw ex;
                }
            }
        }

        private async Task DeleteEmployee(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = apiUrl + "Delete/" + id;

                    HttpResponseMessage response;
                    response = await client.DeleteAsync(url);

                    if (response is not null && response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        //Do Staff
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                    throw ex;
                }
            }
        }
        private void ClearInputs()
        {
            #region ClearInputs
            Id.Text = string.Empty;
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            MailAddress.Text = string.Empty;
            Salary.Text = string.Empty;
            #endregion
        }
    }
}
