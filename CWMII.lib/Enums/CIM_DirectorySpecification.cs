namespace CWMII.lib.Enums {
	public enum CIM_DirectorySpecification {
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

	public static class CIM_DirectorySpecificationExtension {
		public static string GetWMIValue(this CIM_DirectorySpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DirectorySpecification", enumOption.ToString());
	}
}