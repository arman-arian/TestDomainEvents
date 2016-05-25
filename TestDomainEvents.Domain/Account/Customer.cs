namespace TestDomainEvents.Domain.Account
{
    public class Customer
    {
        public int Id { get; set; }

        public string NationalIdentity { get; set; }

        public string FullName { get; set; }

        public Account Account { get; set; }
    }
}
