namespace CWMII.lib.Enums {
	public enum Win32_Keyboard {
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

	public static class Win32_KeyboardExtension {
		public static string GetWMIValue(this Win32_Keyboard enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Keyboard", enumOption.ToString());
	}
}