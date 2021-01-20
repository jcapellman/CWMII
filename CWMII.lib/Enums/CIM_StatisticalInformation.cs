namespace CWMII.lib.Enums {
	public enum CIM_StatisticalInformation {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AvailableMemory,
		AvailableMemoryForBalancing,
		AveragePressure,
		SystemCurrentPressure
	}

	public static class CIM_StatisticalInformationExtension {
		public static string GetWMIValue(this CIM_StatisticalInformation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_StatisticalInformation", enumOption.ToString());
	}
}