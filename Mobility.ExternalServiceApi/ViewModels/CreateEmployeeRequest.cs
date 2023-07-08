namespace Mobility.ExternalServiceApi.ViewModels
{
    public class CreateOrUpdateEmployeeRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
    }
}
