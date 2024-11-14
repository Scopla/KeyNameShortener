using CodingExamples.GenerateKeys.DataGeneration.Contract.DataClasses;

namespace CodingExamples.GenerateKeys.DataGeneration.Contract;

public interface ITestDataGenerator
{
    IEnumerable<Company> GetCompanies();
}