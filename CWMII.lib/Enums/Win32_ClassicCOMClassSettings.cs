namespace CWMII.lib.Enums {
	public enum Win32_ClassicCOMClassSettings {
		Element,
		Setting
	}

	public static class Win32_ClassicCOMClassSettingsExtension {
		public static string GetWMIValue(this Win32_ClassicCOMClassSettings enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ClassicCOMClassSettings", enumOption.ToString());
	}
}