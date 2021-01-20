namespace CWMII.lib.Enums {
	public enum Win32_EnvironmentSpecification {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Environment,
		Value
	}

	public static class Win32_EnvironmentSpecificationExtension {
		public static string GetWMIValue(this Win32_EnvironmentSpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_EnvironmentSpecification", enumOption.ToString());
	}
}