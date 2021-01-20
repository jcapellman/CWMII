namespace CWMII.lib.Enums {
	public enum CIM_Service {
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

	public static class CIM_ServiceExtension {
		public static string GetWMIValue(this CIM_Service enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Service", enumOption.ToString());
	}
}