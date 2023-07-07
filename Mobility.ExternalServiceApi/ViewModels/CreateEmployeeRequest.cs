namespace Mobility.ExternalServiceApi.ViewModels
{
    public class CreateOrUpdateEmployeeRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public int Salary { get; set; }
    }
}
