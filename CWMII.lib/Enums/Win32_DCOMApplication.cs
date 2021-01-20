namespace CWMII.lib.Enums {
	public enum Win32_DCOMApplication {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AppID
	}

	public static class Win32_DCOMApplicationExtension {
		public static string GetWMIValue(this Win32_DCOMApplication enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DCOMApplication", enumOption.ToString());
	}
}