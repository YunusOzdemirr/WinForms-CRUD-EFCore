using Microsoft.EntityFrameworkCore;
using Mobility.Data.Context;
using Mobility.Data.Models;
using System.Windows.Forms;

namespace MobilityApp.Pages.EfCore
{
    public partial class EfCorePage : Form
    {
        public EfCorePage()
        {
            InitializeComponent();
        }
        BindingSource bindingSource = new BindingSource();
        Employee selectedEmployee;
        int rowIndex = 0;

        #region input
        private void Id_TextChanged(object sender, EventArgs e)
        {
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void MailAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion


        private async void Create_Click(object sender, EventArgs e)
        {
            try
            {
                using (MobilityContext context = new MobilityContext())
                {
                    var employee = new Employee()
                    {
                        FirstName = FirstName.Text,
                        MailAddress = MailAddress.Text,
                        LastName = LastName.Text,
                        Salary = decimal.Parse(Salary.Text),
                        Age=int.Parse(Age.Text)
                    };
                    await context.Employees.AddAsync(employee);
                    var id = await context.SaveChangesAsync();
                    employee.Id = id;
                    bindingSource.Add(employee);
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

        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null && string.IsNullOrWhiteSpace(Id.Text))
                    MessageBox.Show("Chosse a person or fill the Id input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (MobilityContext context = new MobilityContext())
                {
                    if (string.IsNullOrEmpty(Id.Text))
                        return;
                    var employee = context.Employees.FirstOrDefault(a => a.Id == int.Parse(Id.Text));
                    if (employee == null)
                    {
                        MessageBox.Show("User is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    employee.FirstName = FirstName.Text;
                    employee.MailAddress = MailAddress.Text;
                    employee.LastName = LastName.Text;
                    employee.Salary = decimal.Parse(Salary.Text);
                    employee.Id = int.Parse(Id.Text);
                    employee.ModifiedDate = DateTime.Now;
                    employee.Age= int.Parse(Age.Text);
                    context.Employees.Update(employee);
                    await context.SaveChangesAsync();

                    var oldIndex = (Employee)bindingSource[rowIndex];
                    oldIndex.FirstName = employee.FirstName;
                    oldIndex.LastName = employee.LastName;
                    oldIndex.MailAddress = employee.MailAddress;
                    oldIndex.Salary = employee.Salary;
                    oldIndex.ModifiedDate = DateTime.Now;
                    oldIndex.Age =employee.Age;
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

                    using (MobilityContext context = new MobilityContext())
                    {
                        context.Employees.Remove(selectedEmployee);
                        context.SaveChanges();
                        MessageBox.Show("Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSource.Remove(selectedEmployee);
                        EmployeesGrid.Refresh();
                    }
                }
                else
                {
                    using (MobilityContext context = new MobilityContext())
                    {
                        var employee = await context.Employees.SingleOrDefaultAsync(a => a.Id == int.Parse(Id.Text));
                        if (employee is null)
                        {
                            MessageBox.Show("Chosse a person or fill the Id input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        context.Employees.Remove(employee);
                        context.SaveChanges();
                        bindingSource.Remove(employee);
                        EmployeesGrid.Refresh();
                        MessageBox.Show("Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void EfCorePage_Load(object sender, EventArgs e)
        {
            using (MobilityContext context = new MobilityContext())
            {
                var employees = context.Employees.ToList();
                bindingSource.DataSource = employees;
                EmployeesGrid.DataSource = bindingSource;
            }
        }

        private void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEmployee = (Employee)bindingSource[e.RowIndex];

            FirstName.Text = selectedEmployee.FirstName;
            LastName.Text = selectedEmployee.LastName;
            MailAddress.Text = selectedEmployee.MailAddress;
            Salary.Text = selectedEmployee.Salary.ToString();
            Id.Text = selectedEmployee.Id.ToString();
            Age.Text = selectedEmployee.Age.ToString();
        }

        private void ClearInputs()
        {
            #region ClearInputs
            Id.Text = string.Empty;
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            MailAddress.Text = string.Empty;
            Salary.Text = string.Empty;
            Age.Text = string.Empty;
            #endregion
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
