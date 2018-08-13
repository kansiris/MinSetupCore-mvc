using System;

namespace MinSetupCore.Utils
{
    public static class DemoExtensions
    {
        public static string ToShortDateString(this DateTime input)
        {
            return input.ToString("d");
        }
    }
}