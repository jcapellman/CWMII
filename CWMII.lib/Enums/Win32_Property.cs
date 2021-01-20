namespace CWMII.lib.Enums {
	public enum Win32_Property {
		Caption,
		Description,
		SettingID,
		ProductCode,
		Property,
		Value
	}

	public static class Win32_PropertyExtension {
		public static string GetWMIValue(this Win32_Property enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Property", enumOption.ToString());
	}
}