using Dapper;
using DapperApplication.Context;
using DapperApplication.Contracts;
using DapperApplication.Entities;

namespace DapperApplication.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _dapperContext;
        public CompanyRepository (DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var GetAllQuery = "Select * from Companies";
            using(var connection = _dapperContext.CreateConnection()) 
            {
                var Companies = await connection.QueryAsync<Company>(GetAllQuery);
                return Companies.ToList();
            }
        }
    }
}
