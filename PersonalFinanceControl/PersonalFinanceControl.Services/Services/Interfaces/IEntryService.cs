
using PersonalFinanceControl.Domain.Entities;

namespace PersonalFinanceControl.Application.Services.Interfaces
{
    public interface IEntryService
    {
        Task<Entry> Add(Entry entry);
        Task Delete(long id);
        Task<Entry> GetById(long id);
        Task<List<Entry>> GetAll();
    }
}
