namespace CWMII.lib.Enums {
	public enum Win32_SoftwareElement {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		BuildNumber,
		CodeSet,
		IdentificationCode,
		LanguageEdition,
		Manufacturer,
		OtherTargetOS,
		SerialNumber,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Attributes,
		InstallState,
		Path
	}

	public static class Win32_SoftwareElementExtension {
		public static string GetWMIValue(this Win32_SoftwareElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareElement", enumOption.ToString());
	}
}