namespace CWMII.lib.Enums {
	public enum Win32_DCOMApplicationAccessAllowedSetting {
		Element,
		Setting
	}

	public static class Win32_DCOMApplicationAccessAllowedSettingExtension {
		public static string GetWMIValue(this Win32_DCOMApplicationAccessAllowedSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DCOMApplicationAccessAllowedSetting", enumOption.ToString());
	}
}