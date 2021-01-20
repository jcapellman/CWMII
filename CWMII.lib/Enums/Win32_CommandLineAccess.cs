namespace CWMII.lib.Enums {
	public enum Win32_CommandLineAccess {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		SystemCreationClassName,
		SystemName,
		Type,
		CommandLine
	}

	public static class Win32_CommandLineAccessExtension {
		public static string GetWMIValue(this Win32_CommandLineAccess enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CommandLineAccess", enumOption.ToString());
	}
}