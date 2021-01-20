namespace CWMII.lib.Enums {
	public enum Win32_IDEController {
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

	public static class Win32_IDEControllerExtension {
		public static string GetWMIValue(this Win32_IDEController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_IDEController", enumOption.ToString());
	}
}