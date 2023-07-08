using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web.UI.WebControls;

namespace Mobility.WebForms.Views.EmployeeExternal
{
    public partial class EmployeeExternal : System.Web.UI.Page
    {
        private string apiUrl = "https://localhost:7054/api/Employee/";

        protected void Page_Load(object sender, EventArgs e)
        {
            BindEmployees();
        }
        protected void SaveEmployee_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string mailAddress = txtMailAddress.Text;
            decimal salary = decimal.Parse(txtSalary.Text);
            int age = int.Parse(txtAge.Text);
            try
            {
                ViewModels.EmployeeViewModel newEmployee = new ViewModels.EmployeeViewModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MailAddress = mailAddress,
                    Salary = salary,
                    Age = age
                };
                var id = CreateOrUpdateEmployee(newEmployee, true);
                newEmployee.Id = id;
                BindEmployees();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        protected void EditEmployee_Click(object sender, EventArgs e)
        {
            Button editButton = (Button)sender;
            int employeeId = Convert.ToInt32(editButton.CommandArgument);
            // Veritabanından çalışanı alın

            using (HttpClient client = new HttpClient())
            {
                var createUrl = apiUrl + "GetAll";

                HttpResponseMessage response = (client.GetAsync(createUrl)).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = (response.Content.ReadAsStringAsync()).Result;
                    var employees = JsonConvert.DeserializeObject<List<Models.Employee>>(responseContent);
                    Models.Employee employee = employees.FirstOrDefault(a => a.Id == employeeId);
                    if (employee != null)
                    {
                        // Çalışan bilgilerini güncelleyin
                        txtEmployeeId.Text = employee.Id.ToString();
                        txtFirstName.Text = employee.FirstName;
                        txtLastName.Text = employee.LastName;
                        txtMailAddress.Text = employee.MailAddress;
                        txtSalary.Text = employee.Salary.ToString();
                        txtAge.Text = employee.Age.ToString();
                    }
                }
            }
        }
        protected void UpdateEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(txtEmployeeId.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string mailAddress = txtMailAddress.Text;
            decimal salary = decimal.Parse(txtSalary.Text);
            int age = int.Parse(txtAge.Text);

            ViewModels.EmployeeViewModel newEmployee = new ViewModels.EmployeeViewModel
            {
                Id = employeeId,
                FirstName = firstName,
                LastName = lastName,
                MailAddress = mailAddress,
                Salary = salary,
                Age = age
            };
            CreateOrUpdateEmployee(newEmployee, false);

            ClearTexts();
            BindEmployees();

        }
        protected void DeleteEmployee_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            int employeeId = Convert.ToInt32(deleteButton.CommandArgument);
            DeleteEmployee(employeeId);
            ClearTexts();
            BindEmployees();
        }

        protected void BindEmployees()
        {
            using (HttpClient client = new HttpClient())
            {
                var createUrl = apiUrl + "GetAll";
                HttpResponseMessage response = (client.GetAsync(createUrl)).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = (response.Content.ReadAsStringAsync()).Result;
                    var employees = JsonConvert.DeserializeObject<List<Models.Employee>>(responseContent);
                    gridEmployees.DataSource = employees;
                    gridEmployees.DataBind();
                }
            }
        }
        protected void Cancel_Click(object sender, EventArgs e)
        {
            ClearTexts();
        }
        private void ClearTexts()
        {
            txtEmployeeId.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMailAddress.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtAge.Text = string.Empty;
        }

        private void DeleteEmployee(int id)
        {
            HttpClient client = new HttpClient();
            string url = apiUrl + "Delete/" + id;

            HttpResponseMessage response;
            response = (client.DeleteAsync(url)).Result;

            if (response != null && response.IsSuccessStatusCode)
            {
                string responseContent = (response.Content.ReadAsStringAsync()).Result;
            }
        }
        private int CreateOrUpdateEmployee(ViewModels.EmployeeViewModel employee, bool isCreate)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;

                if (isCreate)
                {
                    string url = apiUrl + "Create";
                    HttpRequestMessage requestMessage = new HttpRequestMessage();
                    requestMessage.Content = JsonContent.Create(employee);
                    requestMessage.Method = HttpMethod.Post;
                    client.BaseAddress = new Uri(url);
                    response = (client.SendAsync(requestMessage)).Result;
                    string responseContent = (response.Content.ReadAsStringAsync()).Result;
                    if (int.TryParse(responseContent, out var id))
                        return id;
                }
                else
                {
                    string url = apiUrl + "Update/" + employee.Id;
                    HttpRequestMessage requestMessage = new HttpRequestMessage();
                    requestMessage.Content = JsonContent.Create(employee);
                    requestMessage.Method = HttpMethod.Put;
                    client.BaseAddress = new Uri(url);
                    requestMessage.RequestUri = new Uri(url);
                    response = (client.SendAsync(requestMessage)).Result;
                    string responseContent = (response.Content.ReadAsStringAsync()).Result;
                }
                return 0;
            }
        }
    }
}