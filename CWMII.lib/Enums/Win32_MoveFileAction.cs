namespace CWMII.lib.Enums {
	public enum Win32_MoveFileAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		DestFolder,
		DestName,
		FileKey,
		Options,
		SourceFolder,
		SourceName
	}

	public static class Win32_MoveFileActionExtension {
		public static string GetWMIValue(this Win32_MoveFileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MoveFileAction", enumOption.ToString());
	}
}