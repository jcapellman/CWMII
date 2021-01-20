namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Tcpip_UDPv6 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DatagramsNoPortPersec,
		DatagramsPersec,
		DatagramsReceivedErrors,
		DatagramsReceivedPersec,
		DatagramsSentPersec
	}

	public static class Win32_PerfFormattedData_Tcpip_UDPv6Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Tcpip_UDPv6 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Tcpip_UDPv6", enumOption.ToString());
	}
}