namespace PersonalFinanceControl.Domain.Entities
{
    public class Entry
    {
        public long Id { get; set; }
        public required string Description { get; set; }
        public decimal Value { get; set; }
        public EntryType EntryType { get; set; }
    }

    public enum EntryType
    {
        Expense = 0,
        Income = 1,
    }
}