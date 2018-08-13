using Newtonsoft.Json;

namespace MinSetupCore.Utils
{
    public static class DemoUtils
    {
        public static string Encode(object input)
        {
            return JsonConvert.SerializeObject(input);
        }
    }
}