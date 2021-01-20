namespace CWMII.lib.Enums {
	public enum Win32_USBHub {
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
		ClassCode,
		CurrentAlternateSettings,
		CurrentConfigValue,
		NumberOfConfigs,
		ProtocolCode,
		SubclassCode,
		USBVersion,
		GangSwitched,
		NumberOfPorts
	}

	public static class Win32_USBHubExtension {
		public static string GetWMIValue(this Win32_USBHub enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_USBHub", enumOption.ToString());
	}
}