namespace CWMII.lib.Enums {
	public enum Win32_AutochkSetting {
		Caption,
		Description,
		SettingID,
		UserInputDelay
	}

	public static class Win32_AutochkSettingExtension {
		public static string GetWMIValue(this Win32_AutochkSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_AutochkSetting", enumOption.ToString());
	}
}