using Bogus;
using CodingExamples.GenerateKeys.DataGeneration.Contract;
using CodingExamples.GenerateKeys.DataGeneration.Contract.DataClasses;

namespace CodingExamples.GenerateKeys.DataGeneration;

internal class FileTestDataGenerator : ITestDataGenerator
{
    private readonly string _filePath;

    public FileTestDataGenerator()
    {
        _filePath = "Companies.csv";
    }

    public FileTestDataGenerator(string filePath)
    {
        _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
    }
    public IEnumerable<Company> GetCompanies()
    {
        return File.ReadAllLines(_filePath)
            .Skip(1)
            .Select(v => FromCsv(v));
    }

    private Company FromCsv(string line)
    {
        string[] values = line.Split(';');
        return new Company()
        {
            Id = int.Parse(values[0]),
            Name = values[1],
            Address = values[2],
        };
    }
}