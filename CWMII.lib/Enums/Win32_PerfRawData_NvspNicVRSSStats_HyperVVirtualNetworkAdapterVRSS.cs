namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		PostmoveReceivePacketsPerSecond,
		PostmoveReceivePacketsTotal,
		PostmoveSendPacketCompletionsPerSecond,
		PostmoveSendPacketCompletionsTotal,
		PostmoveSendPacketsPerSecond,
		PostmoveSendPacketsTotal,
		ReceivePacketPerSecond,
		ReceivePacketTotal,
		ReceiveProcessor,
		ReceiveProcessorGroup,
		SendPacketCompletionsPerSecond,
		SendPacketCompletionsTotal,
		SendPacketPerSecond,
		SendPacketTotal,
		SendProcessor,
		SendProcessorGroup
	}

	public static class Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSSExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NvspNicVRSSStats_HyperVVirtualNetworkAdapterVRSS", enumOption.ToString());
	}
}