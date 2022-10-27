
using Newtonsoft.Json;

namespace Entities
{
    public static class Seeder
    {
        private static string _db = Path.Combine(Directory.GetCurrentDirectory());

        public static async Task<T> ReadJson<T>(string jsonFile)
        {
            var readText = await File.ReadAllTextAsync(jsonFile);          
            var serializer = new JsonSerializer();
            var stringReader = new StringReader(readText);
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;
                while (jsonReader.Read())
                {
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
            return default;
        }
        public static List<T> ReadJsonMultiple<T>(string jsonFile)
        {
            var readText = File.ReadAllText(_db + jsonFile);
            var objects = new List<T>();
            var serializer = new JsonSerializer();
            var stringReader = new StringReader(readText);
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;
                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);
                    objects.Add(json);
                }
            }
            return objects;
        }
    }
}
