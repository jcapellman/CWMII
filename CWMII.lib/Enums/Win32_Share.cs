namespace CWMII.lib.Enums {
	public enum Win32_Share {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AccessMask,
		AllowMaximum,
		MaximumAllowed,
		Path,
		Type
	}

	public static class Win32_ShareExtension {
		public static string GetWMIValue(this Win32_Share enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Share", enumOption.ToString());
	}
}