namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BuildScatterGatherCyclesPersec,
		InterruptCyclesPersec,
		InterruptDPCCyclesPersec,
		InterruptDPCLatencyCyclesPersec,
		MiniportReturnPacketCyclesPersec,
		MiniportRSSIndirectionTableChangeCycles,
		MiniportSendCyclesPersec,
		NDISReceiveIndicationCyclesPersec,
		NDISReturnPacketCyclesPersec,
		NDISSendCompleteCyclesPersec,
		NDISSendCyclesPersec,
		StackReceiveIndicationCyclesPersec,
		StackSendCompleteCyclesPersec
	}

	public static class Win32_PerfRawData_Counters_PerProcessorNetworkActivityCyclesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_PerProcessorNetworkActivityCycles", enumOption.ToString());
	}
}