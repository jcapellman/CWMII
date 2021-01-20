namespace CWMII.lib.Enums {
	public enum Win32_TerminalService {
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
		WaitHint,
		DisconnectedSessions,
		TotalSessions
	}

	public static class Win32_TerminalServiceExtension {
		public static string GetWMIValue(this Win32_TerminalService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_TerminalService", enumOption.ToString());
	}
}