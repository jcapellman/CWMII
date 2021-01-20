namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Tcpip_NetworkAdapter {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BytesReceivedPersec,
		BytesSentPersec,
		BytesTotalPersec,
		CurrentBandwidth,
		OffloadedConnections,
		OutputQueueLength,
		PacketsOutboundDiscarded,
		PacketsOutboundErrors,
		PacketsPersec,
		PacketsReceivedDiscarded,
		PacketsReceivedErrors,
		PacketsReceivedNonUnicastPersec,
		PacketsReceivedPersec,
		PacketsReceivedUnicastPersec,
		PacketsReceivedUnknown,
		PacketsSentNonUnicastPersec,
		PacketsSentPersec,
		PacketsSentUnicastPersec,
		TCPActiveRSCConnections,
		TCPRSCAveragePacketSize,
		TCPRSCCoalescedPacketsPersec,
		TCPRSCExceptionsPersec
	}

	public static class Win32_PerfRawData_Tcpip_NetworkAdapterExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Tcpip_NetworkAdapter enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Tcpip_NetworkAdapter", enumOption.ToString());
	}
}