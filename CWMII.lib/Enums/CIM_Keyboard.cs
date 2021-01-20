namespace CWMII.lib.Enums {
	public enum CIM_Keyboard {
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
		IsLocked,
		Layout,
		NumberOfFunctionKeys,
		Password
	}

	public static class CIM_KeyboardExtension {
		public static string GetWMIValue(this CIM_Keyboard enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Keyboard", enumOption.ToString());
	}
}