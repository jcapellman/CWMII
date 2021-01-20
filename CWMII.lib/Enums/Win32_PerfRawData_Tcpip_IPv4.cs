namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Tcpip_IPv4 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DatagramsForwardedPersec,
		DatagramsOutboundDiscarded,
		DatagramsOutboundNoRoute,
		DatagramsPersec,
		DatagramsReceivedAddressErrors,
		DatagramsReceivedDeliveredPersec,
		DatagramsReceivedDiscarded,
		DatagramsReceivedHeaderErrors,
		DatagramsReceivedPersec,
		DatagramsReceivedUnknownProtocol,
		DatagramsSentPersec,
		FragmentationFailures,
		FragmentedDatagramsPersec,
		FragmentReassemblyFailures,
		FragmentsCreatedPersec,
		FragmentsReassembledPersec,
		FragmentsReceivedPersec
	}

	public static class Win32_PerfRawData_Tcpip_IPv4Extension {
		public static string GetWMIValue(this Win32_PerfRawData_Tcpip_IPv4 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Tcpip_IPv4", enumOption.ToString());
	}
}