namespace CWMII.lib.Enums {
	public enum Win32_ProgramGroupOrItem {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		GroupName,
		UserName
	}

	public static class Win32_ProgramGroupOrItemExtension {
		public static string GetWMIValue(this Win32_ProgramGroupOrItem enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProgramGroupOrItem", enumOption.ToString());
	}
}