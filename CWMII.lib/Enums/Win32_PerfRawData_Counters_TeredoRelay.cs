namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_TeredoRelay {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		InTeredoRelayErrorPacketsDestinationError,
		InTeredoRelayErrorPacketsHeaderError,
		InTeredoRelayErrorPacketsSourceError,
		InTeredoRelayErrorPacketsTotal,
		InTeredoRelaySuccessPacketsBubbles,
		InTeredoRelaySuccessPacketsDataPackets,
		InTeredoRelaySuccessPacketsDataPacketsKernelMode,
		InTeredoRelaySuccessPacketsDataPacketsUserMode,
		InTeredoRelaySuccessPacketsTotal,
		InTeredoRelayTotalPacketsSuccessError,
		InTeredoRelayTotalPacketsSuccessErrorPersec,
		OutTeredoRelayErrorPackets,
		OutTeredoRelayErrorPacketsDestinationError,
		OutTeredoRelayErrorPacketsHeaderError,
		OutTeredoRelayErrorPacketsSourceError,
		OutTeredoRelaySuccessPackets,
		OutTeredoRelaySuccessPacketsBubbles,
		OutTeredoRelaySuccessPacketsDataPackets,
		OutTeredoRelaySuccessPacketsDataPacketsKernelMode,
		OutTeredoRelaySuccessPacketsDataPacketsUserMode,
		OutTeredoRelayTotalPacketsSuccessError,
		OutTeredoRelayTotalPacketsSuccessErrorPersec
	}

	public static class Win32_PerfRawData_Counters_TeredoRelayExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_TeredoRelay enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_TeredoRelay", enumOption.ToString());
	}
}