using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobility.WebForms.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
    }
}