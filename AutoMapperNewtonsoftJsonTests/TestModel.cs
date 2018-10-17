using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    public class TestModel : ITestModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double DoubleValue { get; set; }
        public float FloatValue { get; set; }
        public List<string> StringList { get; set; }
        public Dictionary<int, string> Dictionary { get; set; }
        public List<Dictionary<int, string>> ListOfDictionaries { get; set; }
    }
}