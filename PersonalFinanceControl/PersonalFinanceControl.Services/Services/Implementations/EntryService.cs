using PersonalFinanceControl.Application.Services.Interfaces;
using PersonalFinanceControl.Domain.Entities;
using System.Formats.Tar;

namespace PersonalFinanceControl.Application.Services.Implementations
{
    public class EntryService : IEntryService
    {
        public async Task<Entry> Add(Entry entry)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Entry> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Entry>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
