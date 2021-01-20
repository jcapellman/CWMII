namespace CWMII.lib.Enums {
	public enum Win32_PnPEntity {
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
		ClassGuid,
		CompatibleID,
		HardwareID,
		Manufacturer,
		PNPClass,
		Present,
		Service
	}

	public static class Win32_PnPEntityExtension {
		public static string GetWMIValue(this Win32_PnPEntity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PnPEntity", enumOption.ToString());
	}
}