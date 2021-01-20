namespace CWMII.lib.Enums {
	public enum CIM_Display {
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

	public static class CIM_DisplayExtension {
		public static string GetWMIValue(this CIM_Display enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Display", enumOption.ToString());
	}
}