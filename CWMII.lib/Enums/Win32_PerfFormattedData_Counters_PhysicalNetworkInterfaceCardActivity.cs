namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DevicePowerState,
		LowPowerTransitionsLifetime,
		PercentTimeSuspendedInstantaneous,
		PercentTimeSuspendedLifetime
	}

	public static class Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivityExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_PhysicalNetworkInterfaceCardActivity", enumOption.ToString());
	}
}