namespace CWMII.lib.Enums {
	public enum Win32_Environment {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		SystemVariable,
		UserName,
		VariableValue
	}

	public static class Win32_EnvironmentExtension {
		public static string GetWMIValue(this Win32_Environment enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Environment", enumOption.ToString());
	}
}