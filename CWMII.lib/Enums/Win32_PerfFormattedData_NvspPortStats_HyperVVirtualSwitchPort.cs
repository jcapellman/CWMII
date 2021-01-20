namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BroadcastPacketsReceivedPersec,
		BroadcastPacketsSentPersec,
		BytesPersec,
		BytesReceivedPersec,
		BytesSentPersec,
		DirectedPacketsReceivedPersec,
		DirectedPacketsSentPersec,
		DroppedPacketsIncomingPersec,
		DroppedPacketsOutgoingPersec,
		ExtensionsDroppedPacketsIncomingPersec,
		ExtensionsDroppedPacketsOutgoingPersec,
		IPsecoffloadBytesReceivePersec,
		IPsecoffloadBytesSentPersec,
		IPsecSAsOffloaded,
		MulticastPacketsReceivedPersec,
		MulticastPacketsSentPersec,
		PacketsPersec,
		PacketsReceivedPersec,
		PacketsSentPersec,
		UnhashedPacketsReceivedPersec,
		UnhashedPacketsSendCompletedPersec
	}

	public static class Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPortExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NvspPortStats_HyperVVirtualSwitchPort", enumOption.ToString());
	}
}