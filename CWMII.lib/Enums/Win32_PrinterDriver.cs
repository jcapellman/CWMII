namespace CWMII.lib.Enums {
	public enum Win32_PrinterDriver {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		Started,
		StartMode,
		SystemCreationClassName,
		SystemName,
		ConfigFile,
		DataFile,
		DefaultDataType,
		DependentFiles,
		DriverPath,
		FilePath,
		HelpFile,
		InfName,
		MonitorName,
		OEMUrl,
		SupportedPlatform,
		Version
	}

	public static class Win32_PrinterDriverExtension {
		public static string GetWMIValue(this Win32_PrinterDriver enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PrinterDriver", enumOption.ToString());
	}
}