namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_SecuritySystemWideStatistics {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ActiveSchannelSessionCacheEntries,
		DigestAuthentications,
		ForwardedKerberosRequests,
		KDCarmoredASRequests,
		KDCarmoredTGSRequests,
		KDCASRequests,
		KDCclaimsawareASRequests,
		KDCclaimsawareserviceassertedidentityTGSrequests,
		KDCclaimsawareTGSRequests,
		KDCclassictypeconstraineddelegationTGSRequests,
		KDCkeytrustASRequests,
		KDCresourcetypeconstraineddelegationTGSRequests,
		KDCTGSRequests,
		KerberosAuthentications,
		NTLMAuthentications,
		SchannelSessionCacheEntries,
		SSLClientSideFullHandshakes,
		SSLClientSideReconnectHandshakes,
		SSLServerSideFullHandshakes,
		SSLServerSideReconnectHandshakes
	}

	public static class Win32_PerfRawData_Counters_SecuritySystemWideStatisticsExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_SecuritySystemWideStatistics enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_SecuritySystemWideStatistics", enumOption.ToString());
	}
}