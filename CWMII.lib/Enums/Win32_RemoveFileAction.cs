namespace CWMII.lib.Enums {
	public enum Win32_RemoveFileAction {
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

	public static class Win32_RemoveFileActionExtension {
		public static string GetWMIValue(this Win32_RemoveFileAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_RemoveFileAction", enumOption.ToString());
	}
}