namespace CWMII.lib.Enums {
	public enum Win32_DisplayConfiguration {
		Caption,
		Description,
		SettingID,
		BitsPerPel,
		DeviceName,
		DisplayFlags,
		DisplayFrequency,
		DitherType,
		DriverVersion,
		ICMIntent,
		ICMMethod,
		LogPixels,
		PelsHeight,
		PelsWidth,
		SpecificationVersion
	}

	public static class Win32_DisplayConfigurationExtension {
		public static string GetWMIValue(this Win32_DisplayConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DisplayConfiguration", enumOption.ToString());
	}
}