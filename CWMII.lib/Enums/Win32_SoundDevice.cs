namespace CWMII.lib.Enums {
	public enum Win32_SoundDevice {
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
		DMABufferSize,
		Manufacturer,
		MPU401Address,
		ProductName
	}

	public static class Win32_SoundDeviceExtension {
		public static string GetWMIValue(this Win32_SoundDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoundDevice", enumOption.ToString());
	}
}