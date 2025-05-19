using System;
namespace TestApi.Common.Entities.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int CompanyId { get; set; }
        
        public string Salary { get; set; }
    }
}
