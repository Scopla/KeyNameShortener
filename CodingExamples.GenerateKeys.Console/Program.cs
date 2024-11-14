using CodingExamples.GenerateKeys.DataGeneration;
using CodingExamples.GenerateKeys.DataGeneration.Contract;

ITestDataGenerator dataGenerator = TestDataGeneratorFactory.CreateInMemoryGenerator(2000);
var companies = dataGenerator.GetCompanies();

//Add Code

//foreach (var s in result.OrderBy(x => x.Key.Length))
//{
//    Console.WriteLine(s.Key + ":" + s.Value.Name);
//}
