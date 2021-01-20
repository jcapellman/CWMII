namespace CWMII.lib.Enums {
	public enum Win32_MotherboardDevice {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Availability,
		ConfigManagerErrorCode,
		ConfigManagerUserConfig,
		CreationClassName,
		DeviceID,
		ErrorCleared,
		ErrorDescription,
		LastErrorCode,
		PNPDeviceID,
		PowerManagementCapabilities,
		PowerManagementSupported,
		StatusInfo,
		SystemCreationClassName,
		SystemName,
		PrimaryBusType,
		RevisionNumber,
		SecondaryBusType
	}

	public static class Win32_MotherboardDeviceExtension {
		public static string GetWMIValue(this Win32_MotherboardDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MotherboardDevice", enumOption.ToString());
	}
}