namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_PacerPipe {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Averagepacketsinnetcard,
		Averagepacketsinsequencer,
		Averagepacketsinshaper,
		Flowmodsrejected,
		Flowsclosed,
		Flowsmodified,
		Flowsopened,
		Flowsrejected,
		Maxpacketsinnetcard,
		Maxpacketsinsequencer,
		Maxpacketsinshaper,
		Maxsimultaneousflows,
		Nonconformingpacketsscheduled,
		NonconformingpacketsscheduledPersec,
		Nonconformingpacketstransmitted,
		NonconformingpacketstransmittedPersec,
		Outofpackets
	}

	public static class Win32_PerfRawData_Counters_PacerPipeExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_PacerPipe enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_PacerPipe", enumOption.ToString());
	}
}