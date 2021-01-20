namespace CWMII.lib.Enums {
	public enum Win32_SecuritySettingOfLogicalFile {
		Element,
		Setting
	}

	public static class Win32_SecuritySettingOfLogicalFileExtension {
		public static string GetWMIValue(this Win32_SecuritySettingOfLogicalFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SecuritySettingOfLogicalFile", enumOption.ToString());
	}
}