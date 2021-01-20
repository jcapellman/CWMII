namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_HvStats_HyperVHypervisor {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		HypervisorStartupCost,
		LogicalProcessors,
		ModernStandbyEntries,
		MonitoredNotifications,
		Partitions,
		PlatformIdleTransitions,
		TotalPages,
		VirtualProcessors
	}

	public static class Win32_PerfRawData_HvStats_HyperVHypervisorExtension {
		public static string GetWMIValue(this Win32_PerfRawData_HvStats_HyperVHypervisor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_HvStats_HyperVHypervisor", enumOption.ToString());
	}
}