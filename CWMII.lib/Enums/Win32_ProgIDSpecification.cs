namespace CWMII.lib.Enums {
	public enum Win32_ProgIDSpecification {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Parent,
		ProgID
	}

	public static class Win32_ProgIDSpecificationExtension {
		public static string GetWMIValue(this Win32_ProgIDSpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProgIDSpecification", enumOption.ToString());
	}
}