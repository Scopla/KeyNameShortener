using CodingExamples.GenerateKeys.DataGeneration.Contract;

namespace CodingExamples.GenerateKeys.DataGeneration;

public static class TestDataGeneratorFactory
{
    public static ITestDataGenerator CreateInMemoryGenerator(int amountOfDataToGenerate)
    {
        return new InMemoryTestDataGenerator(amountOfDataToGenerate);
    }

    public static ITestDataGenerator CreateFileGenerator()
    {
        return new FileTestDataGenerator();
    }
    public static ITestDataGenerator CreateFileGenerator(string pathToFile)
    {
        return new FileTestDataGenerator(pathToFile);
    }
}