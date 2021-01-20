namespace CWMII.lib.Enums {
	public enum Win32_LogicalProgramGroupItemDataFile {
		Antecedent,
		Dependent
	}

	public static class Win32_LogicalProgramGroupItemDataFileExtension {
		public static string GetWMIValue(this Win32_LogicalProgramGroupItemDataFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalProgramGroupItemDataFile", enumOption.ToString());
	}
}