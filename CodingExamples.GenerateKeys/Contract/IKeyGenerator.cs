using CodingExamples.GenerateKeys.DataGeneration.Contract.DataClasses;

namespace CodingExamples.GenerateKeys.DataGeneration.Contract;

public interface IKeyGenerator<T>
{
    public T CreateKeys(IEnumerable<Company> values);
}