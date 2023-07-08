using Mobility.WebForms.Data.Context;
using System;
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
        protected  void SaveEmployee_Click(object sender, EventArgs e)
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
                    employee.FirstName = txtEditFirstName.Text;
                    employee.LastName = txtEditLastName.Text;
                    employee.MailAddress = txtEditMailAddress.Text;
                    employee.Salary = Convert.ToDecimal(txtEditSalary.Text);
                    employee.Age = Convert.ToInt32(txtEditAge.Text);

                    dbContext.SaveChanges();
                }
            }

            // Çalışanları 
        }
        protected void DeleteEmployee_Click(object sender, EventArgs e)
        {
            // Olay işleyici kodu
        }
        protected void Cancel_Click(object sender, EventArgs e)
        {
            // Olay işleyici kodu
        }

        protected void BindEmployees()
        {
            MobilityContext context = new MobilityContext();
            var employees = context.Employees.ToList();
            gridEmployees.DataSource = employees;
            gridEmployees.DataBind();
        }
    }

}