namespace CWMII.lib.Enums {
	public enum CIM_FileAction {
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
		DirProperty,
		FileKey,
		FileName,
		InstallMode
	}

	public static class CIM_FileActionExtension {
		public static string GetWMIValue(this CIM_FileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_FileAction", enumOption.ToString());
	}
}