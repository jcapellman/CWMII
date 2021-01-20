namespace CWMII.lib.Enums {
	public enum Win32_Binary {
		Caption,
		Description,
		SettingID,
		Data,
		Name,
		ProductCode
	}

	public static class Win32_BinaryExtension {
		public static string GetWMIValue(this Win32_Binary enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Binary", enumOption.ToString());
	}
}