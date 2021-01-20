namespace CWMII.lib.Enums {
	public enum Win32_PrinterSetting {
		Element,
		Setting
	}

	public static class Win32_PrinterSettingExtension {
		public static string GetWMIValue(this Win32_PrinterSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PrinterSetting", enumOption.ToString());
	}
}