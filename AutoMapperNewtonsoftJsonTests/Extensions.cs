using AutoMapper;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AutoMapperNewtonsoftJsonTests
{
    public static class Extensions
    {
        public static T JsonClone<T>(this T source)
        {
            if (ReferenceEquals(source, null))
            {
                return default(T);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        }

        public static T AutoMapperClone<T>(this T source)
        {
            T copy = default(T);
            copy = Mapper.Map<T, T>(source);
            return copy;
        }

        public static ITestModel ManualClone(this ITestModel source)
        {
            return new TestModel
            {
                Id = source.Id,
                Description = source.Description,
                DoubleValue = source.DoubleValue,
                FloatValue = source.FloatValue,
                StringList = source.StringList,
                Dictionary = source.Dictionary,
                ListOfDictionaries = source.ListOfDictionaries
            };
        }

        public static List<T> ManualClone<T>(this IEnumerable<T> source)
        {
            return new List<T>(source);
        }
    }
}