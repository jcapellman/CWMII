namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfOS_Objects {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Events,
		Mutexes,
		Processes,
		Sections,
		Semaphores,
		Threads
	}

	public static class Win32_PerfFormattedData_PerfOS_ObjectsExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfOS_Objects enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfOS_Objects", enumOption.ToString());
	}
}