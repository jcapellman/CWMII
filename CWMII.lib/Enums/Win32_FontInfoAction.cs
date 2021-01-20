namespace CWMII.lib.Enums {
	public enum Win32_FontInfoAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		File,
		FontTitle
	}

	public static class Win32_FontInfoActionExtension {
		public static string GetWMIValue(this Win32_FontInfoAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_FontInfoAction", enumOption.ToString());
	}
}