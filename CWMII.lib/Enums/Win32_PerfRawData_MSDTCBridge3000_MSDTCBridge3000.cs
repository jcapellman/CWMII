namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_MSDTCBridge3000_MSDTCBridge3000 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Averageparticipantcommitresponsetime,
		Averageparticipantcommitresponsetime_Base,
		Averageparticipantprepareresponsetime,
		Averageparticipantprepareresponsetime_Base,
		CommitretrycountPersec,
		FaultsreceivedcountPersec,
		FaultssentcountPersec,
		MessagesendfailuresPersec,
		PreparedretrycountPersec,
		PrepareretrycountPersec,
		ReplayretrycountPersec
	}

	public static class Win32_PerfRawData_MSDTCBridge3000_MSDTCBridge3000Extension {
		public static string GetWMIValue(this Win32_PerfRawData_MSDTCBridge3000_MSDTCBridge3000 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_MSDTCBridge3000_MSDTCBridge3000", enumOption.ToString());
	}
}