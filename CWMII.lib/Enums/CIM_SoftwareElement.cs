namespace CWMII.lib.Enums {
	public enum CIM_SoftwareElement {
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
		PrimaryBIOS,
		BiosCharacteristics,
		BIOSVersion,
		CurrentLanguage,
		EmbeddedControllerMajorVersion,
		EmbeddedControllerMinorVersion,
		InstallableLanguages,
		ListOfLanguages,
		ReleaseDate,
		SMBIOSBIOSVersion,
		SMBIOSMajorVersion,
		SMBIOSMinorVersion,
		SMBIOSPresent,
		SystemBiosMajorVersion,
		SystemBiosMinorVersion
	}

	public static class CIM_SoftwareElementExtension {
		public static string GetWMIValue(this CIM_SoftwareElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SoftwareElement", enumOption.ToString());
	}
}