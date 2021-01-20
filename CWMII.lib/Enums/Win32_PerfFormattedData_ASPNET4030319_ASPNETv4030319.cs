namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ApplicationRestarts,
		ApplicationsRunning,
		AuditFailureEventsRaised,
		AuditSuccessEventsRaised,
		ErrorEventsRaised,
		InfrastructureErrorEventsRaised,
		RequestErrorEventsRaised,
		RequestExecutionTime,
		RequestsCurrent,
		RequestsDisconnected,
		RequestsInNativeQueue,
		RequestsQueued,
		RequestsRejected,
		RequestWaitTime,
		StateServerSessionsAbandoned,
		StateServerSessionsActive,
		StateServerSessionsTimedOut,
		StateServerSessionsTotal,
		WorkerProcessesRunning,
		WorkerProcessRestarts
	}

	public static class Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_ASPNET4030319_ASPNETv4030319", enumOption.ToString());
	}
}