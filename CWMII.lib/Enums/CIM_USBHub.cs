namespace CWMII.lib.Enums {
	public enum CIM_USBHub {
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

	public static class CIM_USBHubExtension {
		public static string GetWMIValue(this CIM_USBHub enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_USBHub", enumOption.ToString());
	}
}