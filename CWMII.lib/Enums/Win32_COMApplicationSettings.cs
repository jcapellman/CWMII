namespace CWMII.lib.Enums {
	public enum Win32_COMApplicationSettings {
		Element,
		Setting
	}

	public static class Win32_COMApplicationSettingsExtension {
		public static string GetWMIValue(this Win32_COMApplicationSettings enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_COMApplicationSettings", enumOption.ToString());
	}
}