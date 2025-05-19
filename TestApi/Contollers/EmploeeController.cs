using Microsoft.AspNetCore.Mvc;
using TestApi.Common.Entities.Domain;
using TestApi.Common.Entities.InputModels;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();
        public EmployeeController()
        {
        }

        [HttpGet()]
        public async Task<ICollection<Employee>> Get()
        {
            return _employees;
        }
        
        [HttpGet("{byId}")]
        public async Task<Employee> Get([FromQuery] int id)
        {
            return _employees.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public async Task<int> Create([FromBody] EmployeeInputModel employeeInputModel)
        {
            var random = new Random();
            var user = new Employee()
            {
                Id = random.Next(1, 1000),
                Name = employeeInputModel.Name,
                Email = employeeInputModel.Email,
                Password = employeeInputModel.Password
            };

            return user.Id;
        }
    }
}