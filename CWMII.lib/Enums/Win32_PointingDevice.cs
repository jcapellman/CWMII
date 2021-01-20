namespace CWMII.lib.Enums {
	public enum Win32_PointingDevice {
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
		Handedness,
		NumberOfButtons,
		PointingType,
		Resolution,
		DeviceInterface,
		DoubleSpeedThreshold,
		HardwareType,
		InfFileName,
		InfSection,
		Manufacturer,
		QuadSpeedThreshold,
		SampleRate,
		Synch
	}

	public static class Win32_PointingDeviceExtension {
		public static string GetWMIValue(this Win32_PointingDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PointingDevice", enumOption.ToString());
	}
}