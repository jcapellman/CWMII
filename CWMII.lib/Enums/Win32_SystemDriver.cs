namespace CWMII.lib.Enums {
	public enum Win32_SystemDriver {
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

	public static class Win32_SystemDriverExtension {
		public static string GetWMIValue(this Win32_SystemDriver enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemDriver", enumOption.ToString());
	}
}