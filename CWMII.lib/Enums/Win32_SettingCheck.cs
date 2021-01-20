namespace CWMII.lib.Enums {
	public enum Win32_SettingCheck {
		Check,
		Setting
	}

	public static class Win32_SettingCheckExtension {
		public static string GetWMIValue(this Win32_SettingCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SettingCheck", enumOption.ToString());
	}
}