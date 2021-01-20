namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_TapiSrv_Telephony {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ActiveLines,
		ActiveTelephones,
		ClientApps,
		CurrentIncomingCalls,
		CurrentOutgoingCalls,
		IncomingCallsPersec,
		Lines,
		OutgoingCallsPersec,
		TelephoneDevices
	}

	public static class Win32_PerfFormattedData_TapiSrv_TelephonyExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_TapiSrv_Telephony enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_TapiSrv_Telephony", enumOption.ToString());
	}
}