using Newtonsoft.Json.Linq;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static string MakeSomeJson() => new JObject().ToString();
    }
}
