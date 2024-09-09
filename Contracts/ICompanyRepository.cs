using DapperApplication.Entities;

namespace DapperApplication.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
