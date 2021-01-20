namespace CWMII.lib.Enums {
	public enum Win32_OfflineFilesMachineConfiguration {
		BackgroundSyncEnabled,
		BackgroundSyncParams,
		DiskSpaceLimitEnabled,
		DiskSpaceLimitParams,
		EconomicalAdminPinningEnabled,
		Enabled,
		ExcludedFileTypes,
		IsConfiguredByWMI,
		MakeAvailableOfflineButtonRemoved,
		OfflineFilesCacheEncrypted,
		SlowLinkEnabled,
		SlowLinkParams,
		SyncOnCostedNetworkEnabled,
		TransparentCachingLatencyThreshold,
		WorkOfflineButtonRemoved
	}

	public static class Win32_OfflineFilesMachineConfigurationExtension {
		public static string GetWMIValue(this Win32_OfflineFilesMachineConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OfflineFilesMachineConfiguration", enumOption.ToString());
	}
}