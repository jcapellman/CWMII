namespace CWMII.lib.Enums {
	public enum CIM_RemoveFileAction {
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

	public static class CIM_RemoveFileActionExtension {
		public static string GetWMIValue(this CIM_RemoveFileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_RemoveFileAction", enumOption.ToString());
	}
}