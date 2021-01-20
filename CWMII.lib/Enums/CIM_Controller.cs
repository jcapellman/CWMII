namespace CWMII.lib.Enums {
	public enum CIM_Controller {
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

	public static class CIM_ControllerExtension {
		public static string GetWMIValue(this CIM_Controller enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Controller", enumOption.ToString());
	}
}