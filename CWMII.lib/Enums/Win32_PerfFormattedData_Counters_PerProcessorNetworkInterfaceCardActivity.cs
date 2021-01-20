namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BuildScatterGatherListCallsPersec,
		DPCsDeferredPersec,
		DPCsQueuedonOtherCPUsPersec,
		DPCsQueuedPersec,
		InterruptsPersec,
		LowResourceReceivedPacketsPersec,
		LowResourceReceiveIndicationsPersec,
		PacketsCoalescedPersec,
		ReceivedPacketsPersec,
		ReceiveIndicationsPersec,
		ReturnedPacketsPersec,
		ReturnPacketCallsPersec,
		RSSIndirectionTableChangeCallsPersec,
		SendCompleteCallsPersec,
		SendRequestCallsPersec,
		SentCompletePacketsPersec,
		SentPacketsPersec,
		TcpOffloadReceivebytesPersec,
		TcpOffloadReceiveIndicationsPersec,
		TcpOffloadSendbytesPersec,
		TcpOffloadSendRequestCallsPersec
	}

	public static class Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivityExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_PerProcessorNetworkInterfaceCardActivity", enumOption.ToString());
	}
}