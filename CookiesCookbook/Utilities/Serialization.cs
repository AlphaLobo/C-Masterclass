using System.Text.Json;

namespace CookiesCookbook.Utilities;

public static class Serialization
{
    public static T? DeserializeFromJson<T>()
    {
        return JsonSerializer.Deserialize<T>((FileReader.ReadFromFile(FileType.Json)));
    }
    
    public static T? DeserializeFromText<T>()
    {
        throw new NotImplementedException();
    }

    public static void SerializeJsonToFile<T>(T item)
    {
        FileReader.WriteToFile(FileType.Json, JsonSerializer.Serialize(item));
    }
    
    public static void SerializeTxtToFile<T>(T item)
    {
        throw new NotImplementedException();
    }
}