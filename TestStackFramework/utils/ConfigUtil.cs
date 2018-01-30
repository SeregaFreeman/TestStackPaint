using System;
using System.Configuration;
using System.IO;

namespace TestStackFramework.utils
{
    public class ConfigUtil
    {
        public static string GetConfigValue(string key)
        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine(currentDir);
            ConfigurationFileMap fileMap = new ConfigurationFileMap(Path.GetFullPath("..//Tests//configs//app.config")); //Path to your config file
            Configuration configuration = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
            return configuration.AppSettings.Settings[key].Value;
        }
    }
}
