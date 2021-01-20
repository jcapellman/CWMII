namespace CWMII.lib.Enums {
	public enum CIM_USBController {
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
		Manufacturer
	}

	public static class CIM_USBControllerExtension {
		public static string GetWMIValue(this CIM_USBController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_USBController", enumOption.ToString());
	}
}