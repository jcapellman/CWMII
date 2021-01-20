namespace CWMII.lib.Enums {
	public enum Win32_Bus {
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
		BusNum,
		BusType
	}

	public static class Win32_BusExtension {
		public static string GetWMIValue(this Win32_Bus enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Bus", enumOption.ToString());
	}
}