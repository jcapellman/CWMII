namespace CWMII.lib.Enums {
	public enum CIM_DirectoryContainsFile {
		GroupComponent,
		PartComponent
	}

	public static class CIM_DirectoryContainsFileExtension {
		public static string GetWMIValue(this CIM_DirectoryContainsFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DirectoryContainsFile", enumOption.ToString());
	}
}