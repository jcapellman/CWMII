namespace CWMII.lib.Enums {
	public enum Win32_COMApplication {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AppID
	}

	public static class Win32_COMApplicationExtension {
		public static string GetWMIValue(this Win32_COMApplication enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_COMApplication", enumOption.ToString());
	}
}