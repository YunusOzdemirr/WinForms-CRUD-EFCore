using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobility.Data.Models;
using Mobility.Data.Repositories;
using Mobility.ExternalServiceApi.ViewModels;

namespace Mobility.ExternalServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(IList<Employee>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employeeRepository.GetAllAsync();
            if (employees is null)
                return NotFound();
            return Ok(employees);
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create([FromBody] CreateOrUpdateEmployeeRequest employee)
        {
            var newEmployee = _mapper.Map<Employee>(employee);
            var id = await _employeeRepository.AddAsync(newEmployee, CancellationToken.None);
            if (id > 0)
                return Ok(id);
            return BadRequest();
        }

        [HttpPut("Update/{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(int id, [FromBody] CreateOrUpdateEmployeeRequest employee)
        {
            var newEmployee = _mapper.Map<Employee>(employee);
            newEmployee.Id = id;
            var isSuccessfull = await _employeeRepository.UpdateAsync(newEmployee, CancellationToken.None);
            if (!isSuccessfull)
                return BadRequest();
            return Ok(isSuccessfull);
        }

        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int id)
        {
            var isSuccessfull = await _employeeRepository.HardDeleteByIdAsync(id, CancellationToken.None);
            if (!isSuccessfull)
                return BadRequest("Yanlış İstek");
            return Ok(isSuccessfull);
        }

    }
}
