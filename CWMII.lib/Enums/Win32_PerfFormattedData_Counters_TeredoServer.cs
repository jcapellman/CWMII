namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_TeredoServer {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		InTeredoServerErrorPacketsAuthenticationError,
		InTeredoServerErrorPacketsDestinationError,
		InTeredoServerErrorPacketsHeaderError,
		InTeredoServerErrorPacketsSourceError,
		InTeredoServerErrorPacketsTotal,
		InTeredoServerSuccessPacketsBubbles,
		InTeredoServerSuccessPacketsEcho,
		InTeredoServerSuccessPacketsRSPrimary,
		InTeredoServerSuccessPacketsRSSecondary,
		InTeredoServerSuccessPacketsTotal,
		InTeredoServerTotalPacketsSuccessError,
		InTeredoServerTotalPacketsSuccessErrorPersec,
		OutTeredoServerRAPrimary,
		OutTeredoServerRASecondary
	}

	public static class Win32_PerfFormattedData_Counters_TeredoServerExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_TeredoServer enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_TeredoServer", enumOption.ToString());
	}
}