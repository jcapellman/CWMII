namespace CWMII.lib.Enums {
	public enum Win32_LogicalProgramGroupDirectory {
		Antecedent,
		Dependent
	}

	public static class Win32_LogicalProgramGroupDirectoryExtension {
		public static string GetWMIValue(this Win32_LogicalProgramGroupDirectory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalProgramGroupDirectory", enumOption.ToString());
	}
}