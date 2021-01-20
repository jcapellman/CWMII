namespace CWMII.lib.Enums {
	public enum CIM_DirectoryAction {
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

	public static class CIM_DirectoryActionExtension {
		public static string GetWMIValue(this CIM_DirectoryAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DirectoryAction", enumOption.ToString());
	}
}