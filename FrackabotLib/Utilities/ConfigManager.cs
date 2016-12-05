using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrackabotLib.Utilities
{
	/// <summary>
	/// 
	/// </summary>
	public static class ConfigManager
	{


		private static NameValueCollection _appSettings;




		/// <summary>
		/// 
		/// </summary>
		public static void LoadAppSettings()
		{
			_appSettings = new NameValueCollection();
			_appSettings = ConfigurationManager.AppSettings;
		}

		/// <summary>
		/// 
		/// </summary>
		public static void SaveAppSettings()
		{
			var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var appSettings = configFile.AppSettings.Settings;
			try
			{
				foreach (var key in _appSettings.AllKeys)
				{
					if (appSettings[key] == null)
					{
						appSettings.Add(key, _appSettings[key]);
					}
					else
					{
						appSettings[key].Value = _appSettings[key];
					}
				}
				configFile.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
			}
			catch (ConfigurationErrorsException ex)
			{
				// TODO: Add exception message to the debug textbox output.
			}
		}

		/// <summary>
		/// Gets a value for the specified key in the internal config collection.
		/// </summary>
		/// <param name="key"></param>
		public static string GetValue(string key)
		{
			if (_appSettings[key] == null)
			{
				return string.Empty;
			}
			return _appSettings[key];
		}

		/// <summary>
		/// Sets a value for the specified key in the internal config collection.
		/// </summary>
		/// <param name="key"></param>
		public static void SetValue(string key, string value)
		{
			if (_appSettings[key] == null)
			{
				_appSettings.Add(key, value);
			}
			_appSettings[key] = value;

		}










	}
}
