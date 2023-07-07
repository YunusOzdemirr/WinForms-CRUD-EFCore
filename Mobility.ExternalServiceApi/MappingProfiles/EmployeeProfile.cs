using AutoMapper;
using Mobility.Data.Models;
using Mobility.ExternalServiceApi.ViewModels;

namespace Mobility.ExternalServiceApi.MappingProfiles
{
    public class EmployeeProfile: Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateOrUpdateEmployeeRequest, Employee>();
        }
    }
}
