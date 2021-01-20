namespace CWMII.lib.Enums {
	public enum Win32_DisplayControllerConfiguration {
		Caption,
		Description,
		SettingID,
		BitsPerPixel,
		ColorPlanes,
		DeviceEntriesInAColorTable,
		DeviceSpecificPens,
		HorizontalResolution,
		Name,
		RefreshRate,
		ReservedSystemPaletteEntries,
		SystemPaletteEntries,
		VerticalResolution,
		VideoMode
	}

	public static class Win32_DisplayControllerConfigurationExtension {
		public static string GetWMIValue(this Win32_DisplayControllerConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DisplayControllerConfiguration", enumOption.ToString());
	}
}