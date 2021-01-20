namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Tcpip_NetworkInterface {
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

	public static class Win32_PerfFormattedData_Tcpip_NetworkInterfaceExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Tcpip_NetworkInterface enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Tcpip_NetworkInterface", enumOption.ToString());
	}
}