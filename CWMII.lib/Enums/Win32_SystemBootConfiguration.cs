namespace CWMII.lib.Enums {
	public enum Win32_SystemBootConfiguration {
		Element,
		Setting
	}

	public static class Win32_SystemBootConfigurationExtension {
		public static string GetWMIValue(this Win32_SystemBootConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemBootConfiguration", enumOption.ToString());
	}
}