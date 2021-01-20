namespace CWMII.lib.Enums {
	public enum Win32_OperatingSystemAutochkSetting {
		Element,
		Setting
	}

	public static class Win32_OperatingSystemAutochkSettingExtension {
		public static string GetWMIValue(this Win32_OperatingSystemAutochkSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OperatingSystemAutochkSetting", enumOption.ToString());
	}
}