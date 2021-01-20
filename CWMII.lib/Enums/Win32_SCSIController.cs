namespace CWMII.lib.Enums {
	public enum Win32_SCSIController {
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
		MaxNumberControlled,
		ProtocolSupported,
		TimeOfLastReset,
		ControllerTimeouts,
		MaxDataWidth,
		MaxTransferRate,
		ProtectionManagement,
		DeviceMap,
		DriverName,
		HardwareVersion,
		Index,
		Manufacturer
	}

	public static class Win32_SCSIControllerExtension {
		public static string GetWMIValue(this Win32_SCSIController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SCSIController", enumOption.ToString());
	}
}