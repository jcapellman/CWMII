namespace CWMII.lib.Enums {
	public enum Win32_LogicalProgramGroupItem {
		Caption,
		Description,
		InstallDate,
		Name,
		Status
	}

	public static class Win32_LogicalProgramGroupItemExtension {
		public static string GetWMIValue(this Win32_LogicalProgramGroupItem enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalProgramGroupItem", enumOption.ToString());
	}
}