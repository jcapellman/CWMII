namespace CWMII.lib.Enums {
	public enum CIM_CreateDirectoryAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		DirectoryName
	}

	public static class CIM_CreateDirectoryActionExtension {
		public static string GetWMIValue(this CIM_CreateDirectoryAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_CreateDirectoryAction", enumOption.ToString());
	}
}