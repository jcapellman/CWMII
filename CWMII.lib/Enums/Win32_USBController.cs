namespace CWMII.lib.Enums {
	public enum Win32_USBController {
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

	public static class Win32_USBControllerExtension {
		public static string GetWMIValue(this Win32_USBController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_USBController", enumOption.ToString());
	}
}