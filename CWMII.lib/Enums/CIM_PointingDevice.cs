namespace CWMII.lib.Enums {
	public enum CIM_PointingDevice {
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

	public static class CIM_PointingDeviceExtension {
		public static string GetWMIValue(this CIM_PointingDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PointingDevice", enumOption.ToString());
	}
}