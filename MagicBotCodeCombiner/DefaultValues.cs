using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBotCodeCombiner
{
    public static class DefaultValues
    {
        public const string BotAssemblyName = "MagicBotCodeCombiner";
        public const bool SPEEDTHINGSUPBOY = false; // just copy files contents to clipboard

        public static List<string> IgnoreFileList = new List<string>() // string.Contains is used
        {
            "FileToIgnore CaseSensitive.cs"
        };
    }
}
