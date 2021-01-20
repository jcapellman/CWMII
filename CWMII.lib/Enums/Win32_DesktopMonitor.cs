namespace CWMII.lib.Enums {
	public enum Win32_DesktopMonitor {
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

	public static class Win32_DesktopMonitorExtension {
		public static string GetWMIValue(this Win32_DesktopMonitor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DesktopMonitor", enumOption.ToString());
	}
}