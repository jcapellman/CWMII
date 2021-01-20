namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_IPHTTPSGlobal {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DropsNeighborresolutiontimeouts,
		ErrorsAuthenticationErrors,
		ErrorsReceiveerrorsontheserver,
		ErrorsTransmiterrorsontheserver,
		InTotalbytesreceived,
		InTotalpacketsreceived,
		OutTotalbytesforwarded,
		OutTotalbytessent,
		OutTotalpacketssent,
		SessionsTotalsessions
	}

	public static class Win32_PerfFormattedData_Counters_IPHTTPSGlobalExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_IPHTTPSGlobal enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_IPHTTPSGlobal", enumOption.ToString());
	}
}