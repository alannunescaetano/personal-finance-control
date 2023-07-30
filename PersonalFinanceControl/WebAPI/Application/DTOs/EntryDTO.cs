using WebAPI.Domain.Entities;

namespace WebAPI.Application.DTOs
{
    public record EntryDTO
    {
        public long Id { get; set; }
        public required string Description { get; set; }
        public decimal Value { get; set; }
        public EntryType EntryType { get; set; }
    }
}
