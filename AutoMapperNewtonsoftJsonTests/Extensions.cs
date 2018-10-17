using AutoMapper;
using Newtonsoft.Json;

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
    }
}