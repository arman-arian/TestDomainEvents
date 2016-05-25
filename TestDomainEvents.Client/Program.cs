using System;
using TestDomainEvents.Services.Services;

namespace TestDomainEvents.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           AccountService service = new AccountService();
            service.Transfer();

            Console.ReadKey();

        }
    }
}
