using System;
using Aquality.Selenium.Core.Utilities;

namespace Web.Utils
{
	public class JsonReader
	{
		public static int GetIntData(string key)
		{
			JsonSettingsFile jsonSettingsFile = new JsonSettingsFile(@"config.json");
			return jsonSettingsFile.GetValue<int>(key);
		}
        public static string GetStringData(string key)
        {
            JsonSettingsFile jsonSettingsFile = new JsonSettingsFile(@"config.json");
            return jsonSettingsFile.GetValue<string>(key);
        }
    }
}
