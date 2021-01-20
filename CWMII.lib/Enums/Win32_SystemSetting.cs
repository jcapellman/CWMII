namespace CWMII.lib.Enums {
	public enum Win32_SystemSetting {
		Element,
		Setting
	}

	public static class Win32_SystemSettingExtension {
		public static string GetWMIValue(this Win32_SystemSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemSetting", enumOption.ToString());
	}
}