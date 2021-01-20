namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NETFramework_NETCLRMemory {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AllocatedBytesPersec,
		FinalizationSurvivors,
		Gen0heapsize,
		Gen0PromotedBytesPerSec,
		Gen1heapsize,
		Gen1PromotedBytesPerSec,
		Gen2heapsize,
		LargeObjectHeapsize,
		NumberBytesinallHeaps,
		NumberGCHandles,
		NumberGen0Collections,
		NumberGen1Collections,
		NumberGen2Collections,
		NumberInducedGC,
		NumberofPinnedObjects,
		NumberofSinkBlocksinuse,
		NumberTotalcommittedBytes,
		NumberTotalreservedBytes,
		PercentTimeinGC,
		ProcessID,
		PromotedFinalizationMemoryfromGen0,
		PromotedMemoryfromGen0,
		PromotedMemoryfromGen1
	}

	public static class Win32_PerfFormattedData_NETFramework_NETCLRMemoryExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NETFramework_NETCLRMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRMemory", enumOption.ToString());
	}
}