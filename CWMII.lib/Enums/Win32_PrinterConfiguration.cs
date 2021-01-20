namespace CWMII.lib.Enums {
	public enum Win32_PrinterConfiguration {
		Caption,
		Description,
		SettingID,
		BitsPerPel,
		Collate,
		Color,
		Copies,
		DeviceName,
		DisplayFlags,
		DisplayFrequency,
		DitherType,
		DriverVersion,
		Duplex,
		FormName,
		HorizontalResolution,
		ICMIntent,
		ICMMethod,
		LogPixels,
		MediaType,
		Name,
		Orientation,
		PaperLength,
		PaperSize,
		PaperWidth,
		PelsHeight,
		PelsWidth,
		PrintQuality,
		Scale,
		SpecificationVersion,
		TTOption,
		VerticalResolution,
		XResolution,
		YResolution
	}

	public static class Win32_PrinterConfigurationExtension {
		public static string GetWMIValue(this Win32_PrinterConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PrinterConfiguration", enumOption.ToString());
	}
}