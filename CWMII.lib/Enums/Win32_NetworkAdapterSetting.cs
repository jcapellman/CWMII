namespace CWMII.lib.Enums {
	public enum Win32_NetworkAdapterSetting {
		Element,
		Setting
	}

	public static class Win32_NetworkAdapterSettingExtension {
		public static string GetWMIValue(this Win32_NetworkAdapterSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkAdapterSetting", enumOption.ToString());
	}
}