namespace CWMII.lib.Enums {
	public enum Win32_WMIElementSetting {
		Element,
		Setting
	}

	public static class Win32_WMIElementSettingExtension {
		public static string GetWMIValue(this Win32_WMIElementSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_WMIElementSetting", enumOption.ToString());
	}
}