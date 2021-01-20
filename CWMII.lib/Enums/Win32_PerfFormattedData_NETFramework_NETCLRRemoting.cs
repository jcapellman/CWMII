namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NETFramework_NETCLRRemoting {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Channels,
		ContextBoundClassesLoaded,
		ContextBoundObjectsAllocPersec,
		ContextProxies,
		Contexts,
		RemoteCallsPersec,
		TotalRemoteCalls
	}

	public static class Win32_PerfFormattedData_NETFramework_NETCLRRemotingExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NETFramework_NETCLRRemoting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRRemoting", enumOption.ToString());
	}
}