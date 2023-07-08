using Mobility.WebForms.Data.Context;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobility.WebForms.Views.Employee
{
    public partial class Employee : Page
    {

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

            // Employee oluşturma işlemleri
            Models.Employee newEmployee = new Models.Employee
            {
                FirstName = firstName,
                LastName = lastName,
                MailAddress = mailAddress,
                Salary = salary,
                Age = age
            };

            using (MobilityContext context = new MobilityContext())
            {
                context.Employees.Add(newEmployee);
                context.SaveChanges();
            }
            BindEmployees();
        }

        protected void EditEmployee_Click(object sender, EventArgs e)
        {
            Button editButton = (Button)sender;
            int employeeId = Convert.ToInt32(editButton.CommandArgument);
            // Veritabanından çalışanı alın
            using (MobilityContext dbContext = new MobilityContext())
            {
                Models.Employee employee = dbContext.Employees.FirstOrDefault(a => a.Id == employeeId);

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
        protected void UpdateEmployee_Click(object sender, EventArgs e)
        {
            var employeeId = int.Parse(txtEmployeeId.Text);
            int age = int.Parse(txtAge.Text);

            // Employee oluşturma işlemleri

            using (MobilityContext dbContext = new MobilityContext())
            {
                Models.Employee employee = dbContext.Employees.FirstOrDefault(emp => emp.Id == employeeId);

                if (employee != null)
                {
                    employee.FirstName = txtFirstName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.MailAddress = txtMailAddress.Text;
                    employee.Salary = Convert.ToDecimal(txtSalary.Text);
                    employee.Age = Convert.ToInt32(txtAge.Text);

                    dbContext.SaveChanges();
                }
            }
            ClearTexts();
            BindEmployees();

        }
        protected void DeleteEmployee_Click(object sender, EventArgs e)
        {
            // Seçilen çalışanın EmployeeId değerini al
            Button deleteButton = (Button)sender;
            int employeeId = Convert.ToInt32(deleteButton.CommandArgument);

            // EmployeeId'ye göre çalışanı veritabanından sil
            using (MobilityContext dbContext = new MobilityContext())
            {
                Models.Employee employee = dbContext.Employees.FirstOrDefault(emp => emp.Id == employeeId);

                if (employee != null)
                {
                    // Çalışanı veritabanından silme işlemini gerçekleştirin
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();

                    // Silme işleminden sonra çalışan listesini güncelleyin
                    BindEmployees();
                }
            }
        }


        protected void BindEmployees()
        {
            MobilityContext context = new MobilityContext();
            var employees = context.Employees.ToList();
            gridEmployees.DataSource = employees;
            gridEmployees.DataBind();
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

    }

}