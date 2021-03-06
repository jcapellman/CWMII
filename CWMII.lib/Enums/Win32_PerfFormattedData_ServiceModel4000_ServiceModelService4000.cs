namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Calls,
		CallsDuration,
		CallsFailed,
		CallsFailedPerSecond,
		CallsFaulted,
		CallsFaultedPerSecond,
		CallsOutstanding,
		CallsPerSecond,
		Instances,
		InstancesCreatedPerSecond,
		PercentOfMaxConcurrentCalls,
		PercentOfMaxConcurrentInstances,
		PercentOfMaxConcurrentSessions,
		QueuedMessagesDropped,
		QueuedMessagesDroppedPerSecond,
		QueuedMessagesRejected,
		QueuedMessagesRejectedPerSecond,
		QueuedPoisonMessages,
		QueuedPoisonMessagesPerSecond,
		ReliableMessagingMessagesDropped,
		ReliableMessagingMessagesDroppedPerSecond,
		ReliableMessagingSessionsFaulted,
		ReliableMessagingSessionsFaultedPerSecond,
		SecurityCallsNotAuthorized,
		SecurityCallsNotAuthorizedPerSecond,
		SecurityValidationandAuthenticationFailures,
		SecurityValidationandAuthenticationFailuresPerSecond,
		TransactedOperationsAborted,
		TransactedOperationsAbortedPerSecond,
		TransactedOperationsCommitted,
		TransactedOperationsCommittedPerSecond,
		TransactedOperationsInDoubt,
		TransactedOperationsInDoubtPerSecond,
		TransactionsFlowed,
		TransactionsFlowedPerSecond
	}

	public static class Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_ServiceModel4000_ServiceModelService4000", enumOption.ToString());
	}
}