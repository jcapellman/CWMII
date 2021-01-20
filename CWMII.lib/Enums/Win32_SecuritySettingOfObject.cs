namespace CWMII.lib.Enums {
	public enum Win32_SecuritySettingOfObject {
		Element,
		Setting
	}

	public static class Win32_SecuritySettingOfObjectExtension {
		public static string GetWMIValue(this Win32_SecuritySettingOfObject enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SecuritySettingOfObject", enumOption.ToString());
	}
}