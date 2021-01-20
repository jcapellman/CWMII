namespace CWMII.lib.Enums {
	public enum Win32_CreateFolderAction {
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

	public static class Win32_CreateFolderActionExtension {
		public static string GetWMIValue(this Win32_CreateFolderAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CreateFolderAction", enumOption.ToString());
	}
}