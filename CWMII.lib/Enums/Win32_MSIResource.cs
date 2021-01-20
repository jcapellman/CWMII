namespace CWMII.lib.Enums {
	public enum Win32_MSIResource {
		Caption,
		Description,
		SettingID,
		Data,
		Name,
		ProductCode
	}

	public static class Win32_MSIResourceExtension {
		public static string GetWMIValue(this Win32_MSIResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MSIResource", enumOption.ToString());
	}
}