namespace CWMII.lib.Enums {
	public enum CIM_SCSIController {
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

	public static class CIM_SCSIControllerExtension {
		public static string GetWMIValue(this CIM_SCSIController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SCSIController", enumOption.ToString());
	}
}