namespace CWMII.lib.Enums {
	public enum Win32_DuplicateFileAction {
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

	public static class Win32_DuplicateFileActionExtension {
		public static string GetWMIValue(this Win32_DuplicateFileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DuplicateFileAction", enumOption.ToString());
	}
}