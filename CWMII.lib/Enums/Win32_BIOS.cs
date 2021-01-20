namespace CWMII.lib.Enums {
	public enum Win32_BIOS {
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

	public static class Win32_BIOSExtension {
		public static string GetWMIValue(this Win32_BIOS enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_BIOS", enumOption.ToString());
	}
}