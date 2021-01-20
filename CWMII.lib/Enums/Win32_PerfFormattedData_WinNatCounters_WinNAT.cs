namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_WinNatCounters_WinNAT {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		CurrentSessionCount,
		DroppedICMPerrorpackets,
		DroppedICMPerrorpacketsPersec,
		DroppedPackets,
		DroppedPacketsPersec,
		InterRoutingDomainHairpinnedPackets,
		InterRoutingDomainHairpinnedPacketsPersec,
		IntraRoutingDomainHairpinnedPackets,
		IntraRoutingDomainHairpinnedPacketsPersec,
		PacketsExternaltoInternal,
		PacketsInternaltoExternal,
		PacketsPersecExternaltoInternal,
		PacketsPersecInternaltoExternal,
		SessionsPersec
	}

	public static class Win32_PerfFormattedData_WinNatCounters_WinNATExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_WinNatCounters_WinNAT enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_WinNatCounters_WinNAT", enumOption.ToString());
	}
}