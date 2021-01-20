namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ClockFrequencyAdjustment,
		ClockFrequencyAdjustmentPPB,
		ComputedTimeOffset,
		NTPClientTimeSourceCount,
		NTPRoundtripDelay,
		NTPServerIncomingRequests,
		NTPServerOutgoingResponses
	}

	public static class Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeServiceExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_MicrosoftWindowsW32TimePerf_WindowsTimeService", enumOption.ToString());
	}
}