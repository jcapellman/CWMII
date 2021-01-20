namespace CWMII.lib.Enums {
	public enum Win32_ServiceSpecification {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Dependencies,
		DisplayName,
		ErrorControl,
		ID,
		LoadOrderGroup,
		Password,
		ServiceType,
		StartName,
		StartType
	}

	public static class Win32_ServiceSpecificationExtension {
		public static string GetWMIValue(this Win32_ServiceSpecification enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ServiceSpecification", enumOption.ToString());
	}
}