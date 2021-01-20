namespace CWMII.lib.Enums {
	public enum CIM_DesktopMonitor {
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
		Bandwidth,
		DisplayType,
		ScreenHeight,
		ScreenWidth,
		MonitorManufacturer,
		MonitorType,
		PixelsPerXLogicalInch,
		PixelsPerYLogicalInch
	}

	public static class CIM_DesktopMonitorExtension {
		public static string GetWMIValue(this CIM_DesktopMonitor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DesktopMonitor", enumOption.ToString());
	}
}