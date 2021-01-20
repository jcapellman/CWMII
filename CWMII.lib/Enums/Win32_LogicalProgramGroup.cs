namespace CWMII.lib.Enums {
	public enum Win32_LogicalProgramGroup {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		GroupName,
		UserName
	}

	public static class Win32_LogicalProgramGroupExtension {
		public static string GetWMIValue(this Win32_LogicalProgramGroup enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalProgramGroup", enumOption.ToString());
	}
}