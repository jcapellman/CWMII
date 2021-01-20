namespace CWMII.lib.Enums {
	public enum Win32_VideoSettings {
		Element,
		Setting
	}

	public static class Win32_VideoSettingsExtension {
		public static string GetWMIValue(this Win32_VideoSettings enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_VideoSettings", enumOption.ToString());
	}
}