namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AbortedTransactions,
		AbortedTransactionsPersec,
		ActiveTransactions,
		ActiveTransactionsMaximum,
		CommittedTransactions,
		CommittedTransactionsPersec,
		ForceAbortedTransactions,
		ForceCommittedTransactions,
		InDoubtTransactions,
		ResponseTimeAverage,
		ResponseTimeMaximum,
		ResponseTimeMinimum,
		TransactionsPersec
	}

	public static class Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinatorExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator", enumOption.ToString());
	}
}