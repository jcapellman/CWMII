namespace CWMII.lib.Enums {
	public enum Win32_DeviceSettings {
		Element,
		Setting
	}

	public static class Win32_DeviceSettingsExtension {
		public static string GetWMIValue(this Win32_DeviceSettings enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DeviceSettings", enumOption.ToString());
	}
}