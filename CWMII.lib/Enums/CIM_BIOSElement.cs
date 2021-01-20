namespace CWMII.lib.Enums {
	public enum CIM_BIOSElement {
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

	public static class CIM_BIOSElementExtension {
		public static string GetWMIValue(this CIM_BIOSElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_BIOSElement", enumOption.ToString());
	}
}