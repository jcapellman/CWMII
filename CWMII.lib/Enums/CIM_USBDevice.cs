namespace CWMII.lib.Enums {
	public enum CIM_USBDevice {
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

	public static class CIM_USBDeviceExtension {
		public static string GetWMIValue(this CIM_USBDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_USBDevice", enumOption.ToString());
	}
}