namespace CWMII.lib.Enums {
	public enum CIM_CopyFileAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		DeleteAfterCopy,
		Destination,
		Source,
		FileKey
	}

	public static class CIM_CopyFileActionExtension {
		public static string GetWMIValue(this CIM_CopyFileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_CopyFileAction", enumOption.ToString());
	}
}