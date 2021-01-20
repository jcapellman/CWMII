namespace CWMII.lib.Enums {
	public enum Win32_DCOMApplicationLaunchAllowedSetting {
		Element,
		Setting
	}

	public static class Win32_DCOMApplicationLaunchAllowedSettingExtension {
		public static string GetWMIValue(this Win32_DCOMApplicationLaunchAllowedSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DCOMApplicationLaunchAllowedSetting", enumOption.ToString());
	}
}