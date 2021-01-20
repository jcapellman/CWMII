namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NETFramework_NETCLRLoading {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AssemblySearchLength,
		BytesinLoaderHeap,
		Currentappdomains,
		CurrentAssemblies,
		CurrentClassesLoaded,
		PercentTimeLoading,
		Rateofappdomains,
		Rateofappdomainsunloaded,
		RateofAssemblies,
		RateofClassesLoaded,
		RateofLoadFailures,
		TotalAppdomains,
		Totalappdomainsunloaded,
		TotalAssemblies,
		TotalClassesLoaded,
		TotalNumberofLoadFailures
	}

	public static class Win32_PerfFormattedData_NETFramework_NETCLRLoadingExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NETFramework_NETCLRLoading enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRLoading", enumOption.ToString());
	}
}