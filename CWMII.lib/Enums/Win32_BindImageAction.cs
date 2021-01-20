namespace CWMII.lib.Enums {
	public enum Win32_BindImageAction {
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
		Path
	}

	public static class Win32_BindImageActionExtension {
		public static string GetWMIValue(this Win32_BindImageAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_BindImageAction", enumOption.ToString());
	}
}