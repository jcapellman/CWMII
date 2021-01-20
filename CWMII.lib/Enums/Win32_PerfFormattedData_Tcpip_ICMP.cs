namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Tcpip_ICMP {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		MessagesOutboundErrors,
		MessagesPersec,
		MessagesReceivedErrors,
		MessagesReceivedPersec,
		MessagesSentPersec,
		ReceivedAddressMask,
		ReceivedAddressMaskReply,
		ReceivedDestUnreachable,
		ReceivedEchoPersec,
		ReceivedEchoReplyPersec,
		ReceivedParameterProblem,
		ReceivedRedirectPersec,
		ReceivedSourceQuench,
		ReceivedTimeExceeded,
		ReceivedTimestampPersec,
		ReceivedTimestampReplyPersec,
		SentAddressMask,
		SentAddressMaskReply,
		SentDestinationUnreachable,
		SentEchoPersec,
		SentEchoReplyPersec,
		SentParameterProblem,
		SentRedirectPersec,
		SentSourceQuench,
		SentTimeExceeded,
		SentTimestampPersec,
		SentTimestampReplyPersec
	}

	public static class Win32_PerfFormattedData_Tcpip_ICMPExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Tcpip_ICMP enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Tcpip_ICMP", enumOption.ToString());
	}
}