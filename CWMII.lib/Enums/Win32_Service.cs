namespace CWMII.lib.Enums {
	public enum Win32_Service {
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
		TagId,
		CheckPoint,
		DelayedAutoStart,
		ProcessId,
		WaitHint
	}

	public static class Win32_ServiceExtension {
		public static string GetWMIValue(this Win32_Service enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Service", enumOption.ToString());
	}
}