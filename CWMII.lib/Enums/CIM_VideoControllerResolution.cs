namespace CWMII.lib.Enums {
	public enum CIM_VideoControllerResolution {
		Caption,
		Description,
		SettingID,
		HorizontalResolution,
		MaxRefreshRate,
		MinRefreshRate,
		NumberOfColors,
		RefreshRate,
		ScanMode,
		VerticalResolution
	}

	public static class CIM_VideoControllerResolutionExtension {
		public static string GetWMIValue(this CIM_VideoControllerResolution enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_VideoControllerResolution", enumOption.ToString());
	}
}