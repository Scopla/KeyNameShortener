using Bogus;
using CodingExamples.GenerateKeys.DataGeneration.Contract;
using CodingExamples.GenerateKeys.DataGeneration.Contract.DataClasses;

namespace CodingExamples.GenerateKeys.DataGeneration
{
    internal class InMemoryTestDataGenerator : ITestDataGenerator
    {
        private readonly int _amount;

        public InMemoryTestDataGenerator(int amount)
        {
            _amount = amount;
        }
        public IEnumerable<Company> GetCompanies()
        {
            var orderIds = 0;
            Randomizer.Seed = new Random(8675310);
            var companies = new Faker<Company>()
                .StrictMode(true)
                .RuleFor(o => o.Id, f => orderIds++)
                .RuleFor(u => u.Name, (f, u) => f.Company.CompanyName())
                .RuleFor(u => u.Address, (f, u) => f.Address.FullAddress());

            return companies.Generate(_amount);
        }
    }
}
