namespace CWMII.lib.Enums {
	public enum Win32_ApplicationService {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		Started,
		StartMode,
		SystemCreationClassName,
		SystemName
	}

	public static class Win32_ApplicationServiceExtension {
		public static string GetWMIValue(this Win32_ApplicationService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ApplicationService", enumOption.ToString());
	}
}