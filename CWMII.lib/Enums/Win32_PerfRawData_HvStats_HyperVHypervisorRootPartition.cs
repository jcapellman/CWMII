namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AddressSpaces,
		AttachedDevices,
		DepositedPages,
		DeviceDMAErrors,
		DeviceInterruptErrors,
		DeviceInterruptMappings,
		DeviceInterruptThrottleEvents,
		GPAPages,
		GPASpaceModificationsPersec,
		HWPRequestedPerformanceLevel,
		IOTLBFlushCost,
		IOTLBFlushCost_Base,
		IOTLBFlushesPersec,
		NestedTLBFreeListSize,
		NestedTLBSize,
		NestedTLBTrimmedPagesPersec,
		PagesRecombinedPersec,
		PagesShatteredPersec,
		RecommendedNestedTLBSize,
		RecommendedVirtualTLBSize,
		SkippedTimerTicks,
		Value1Gdevicepages,
		Value1GGPApages,
		Value2Mdevicepages,
		Value2MGPApages,
		Value4Kdevicepages,
		Value4KGPApages,
		VirtualProcessors,
		VirtualTLBFlushEntiresPersec,
		VirtualTLBPages
	}

	public static class Win32_PerfRawData_HvStats_HyperVHypervisorRootPartitionExtension {
		public static string GetWMIValue(this Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_HvStats_HyperVHypervisorRootPartition", enumOption.ToString());
	}
}