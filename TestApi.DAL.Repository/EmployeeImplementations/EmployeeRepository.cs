using Dapper;
using Npgsql;
using TestApi.DAL.Contracts.EmployeeInterfaces;
using TestApi.Common.Entities.Domain;

namespace TestApi.DAL.Repository.EmployeeImplementations
{

    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
        }
    }
}