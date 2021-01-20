namespace CWMII.lib.Enums {
	public enum Win32_ClassicCOMClass {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		ComponentId
	}

	public static class Win32_ClassicCOMClassExtension {
		public static string GetWMIValue(this Win32_ClassicCOMClass enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ClassicCOMClass", enumOption.ToString());
	}
}