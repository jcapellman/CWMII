namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_TeredoClient {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		InTeredoBubble,
		InTeredoData,
		InTeredoDataKernelMode,
		InTeredoDataUserMode,
		InTeredoInvalid,
		InTeredoRouterAdvertisement,
		OutTeredoBubble,
		OutTeredoData,
		OutTeredoDataKernelMode,
		OutTeredoDataUserMode,
		OutTeredoRouterSolicitation
	}

	public static class Win32_PerfFormattedData_Counters_TeredoClientExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_TeredoClient enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_TeredoClient", enumOption.ToString());
	}
}