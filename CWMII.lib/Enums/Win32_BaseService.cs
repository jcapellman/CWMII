namespace CWMII.lib.Enums {
	public enum Win32_BaseService {
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
		AcceptPause,
		AcceptStop,
		DesktopInteract,
		DisplayName,
		ErrorControl,
		ExitCode,
		PathName,
		ServiceSpecificExitCode,
		ServiceType,
		StartName,
		State,
		TagId
	}

	public static class Win32_BaseServiceExtension {
		public static string GetWMIValue(this Win32_BaseService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_BaseService", enumOption.ToString());
	}
}