namespace CWMII.lib.Enums {
	public enum Win32_OSRecoveryConfiguration {
		Caption,
		Description,
		SettingID,
		AutoReboot,
		DebugFilePath,
		DebugInfoType,
		ExpandedDebugFilePath,
		ExpandedMiniDumpDirectory,
		KernelDumpOnly,
		MiniDumpDirectory,
		Name,
		OverwriteExistingDebugFile,
		SendAdminAlert,
		WriteDebugInfo,
		WriteToSystemLog
	}

	public static class Win32_OSRecoveryConfigurationExtension {
		public static string GetWMIValue(this Win32_OSRecoveryConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OSRecoveryConfiguration", enumOption.ToString());
	}
}