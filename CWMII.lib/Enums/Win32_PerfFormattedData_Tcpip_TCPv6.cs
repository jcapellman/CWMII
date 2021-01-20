namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Tcpip_TCPv6 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ConnectionFailures,
		ConnectionsActive,
		ConnectionsEstablished,
		ConnectionsPassive,
		ConnectionsReset,
		SegmentsPersec,
		SegmentsReceivedPersec,
		SegmentsRetransmittedPersec,
		SegmentsSentPersec
	}

	public static class Win32_PerfFormattedData_Tcpip_TCPv6Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Tcpip_TCPv6 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Tcpip_TCPv6", enumOption.ToString());
	}
}