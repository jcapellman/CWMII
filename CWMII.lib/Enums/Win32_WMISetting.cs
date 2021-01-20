namespace CWMII.lib.Enums {
	public enum Win32_WMISetting {
		Caption,
		Description,
		SettingID,
		ASPScriptDefaultNamespace,
		ASPScriptEnabled,
		AutorecoverMofs,
		AutoStartWin9X,
		BackupInterval,
		BackupLastTime,
		BuildVersion,
		DatabaseDirectory,
		DatabaseMaxSize,
		EnableAnonWin9xConnections,
		EnableEvents,
		EnableStartupHeapPreallocation,
		HighThresholdOnClientObjects,
		HighThresholdOnEvents,
		InstallationDirectory,
		LastStartupHeapPreallocation,
		LoggingDirectory,
		LoggingLevel,
		LowThresholdOnClientObjects,
		LowThresholdOnEvents,
		MaxLogFileSize,
		MaxWaitOnClientObjects,
		MaxWaitOnEvents,
		MofSelfInstallDirectory
	}

	public static class Win32_WMISettingExtension {
		public static string GetWMIValue(this Win32_WMISetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_WMISetting", enumOption.ToString());
	}
}