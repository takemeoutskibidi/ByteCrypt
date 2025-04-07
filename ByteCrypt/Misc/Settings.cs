using System;
using System.IO;
using Newtonsoft.Json;

namespace Phantom
{
    internal class Settings
    {
        private static string savepath = AppDomain.CurrentDomain.BaseDirectory + "\\bin\\settings.json";

        internal static SettingsObject Load()
        {
            if (File.Exists(savepath))
            {
                return JsonConvert.DeserializeObject<SettingsObject>(File.ReadAllText(savepath));
            }
            return null;
        }

        internal static void Save(SettingsObject obj) => File.WriteAllText(savepath, JsonConvert.SerializeObject(obj, Formatting.Indented));
    }

    internal class SettingsObject
    {
        public string inputFile { get; set; }

        public bool antiDebug { get; set; }

        public bool antiVM { get; set; }
        
        public bool selfDelete { get; set; }

        public bool hidden { get; set; }

        public bool runas { get; set; }
        
        public bool startup { get; set; }
        
        public bool uacBypass { get; set; }
        
        public bool rootkit { get; set; }

        public bool mutex { get; set; }

        public bool executionDelay { get; set; }

        public bool messageBox { get; set; }

        public string messageboxcontent { get; set; }

        public bool customPowershell { get; set; }

        public string powershellcontents { get; set; }

        public string[] bindedFiles { get; set; }
    }
}