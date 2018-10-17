using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    public interface ITestModel
    {
        string Description { get; set; }
        Dictionary<int, string> Dictionary { get; set; }
        double DoubleValue { get; set; }
        float FloatValue { get; set; }
        int Id { get; set; }
        List<Dictionary<int, string>> ListOfDictionaries { get; set; }
        List<string> StringList { get; set; }
    }
}