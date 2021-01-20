namespace CWMII.lib.Enums {
	public enum CIM_Check {
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

	public static class CIM_CheckExtension {
		public static string GetWMIValue(this CIM_Check enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Check", enumOption.ToString());
	}
}