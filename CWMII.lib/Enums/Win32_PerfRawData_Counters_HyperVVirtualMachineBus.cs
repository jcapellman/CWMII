namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_HyperVVirtualMachineBus {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		InterruptsReceivedPersec,
		InterruptsSentPersec,
		ThrottleEvents
	}

	public static class Win32_PerfRawData_Counters_HyperVVirtualMachineBusExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_HyperVVirtualMachineBus enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_HyperVVirtualMachineBus", enumOption.ToString());
	}
}