namespace CWMII.lib.Enums {
	public enum Win32_DirectorySpecification {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		DirectoryPath,
		DirectoryType,
		DefaultDir,
		Directory
	}

	public static class Win32_DirectorySpecificationExtension {
		public static string GetWMIValue(this Win32_DirectorySpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DirectorySpecification", enumOption.ToString());
	}
}