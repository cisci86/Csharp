using Newtonsoft.Json;

namespace Exercise_5
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Dark_Blue,
        Dark_Green,
        Light_Blue,
        Light_Green,
        Yellow,
        Orange,
        Pink,
        Purple,
    }
    //public class StringEnumConverter : JsonConverter
    //{
    //    [JsonConverter(typeof(StringEnumConverter))]
    //    public Color Color { get; set; }
    //    public override bool CanConvert(Type objectType)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
