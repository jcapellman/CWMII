namespace CWMII.lib.Enums {
	public enum Win32_COMClass {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		ComponentId
	}

	public static class Win32_COMClassExtension {
		public static string GetWMIValue(this Win32_COMClass enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_COMClass", enumOption.ToString());
	}
}