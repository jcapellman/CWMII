namespace CWMII.lib.Enums {
	public enum Win32_Process {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		CreationDate,
		CSCreationClassName,
		CSName,
		ExecutionState,
		Handle,
		KernelModeTime,
		OSCreationClassName,
		OSName,
		Priority,
		TerminationDate,
		UserModeTime,
		WorkingSetSize,
		CommandLine,
		ExecutablePath,
		HandleCount,
		MaximumWorkingSetSize,
		MinimumWorkingSetSize,
		OtherOperationCount,
		OtherTransferCount,
		PageFaults,
		PageFileUsage,
		ParentProcessId,
		PeakPageFileUsage,
		PeakVirtualSize,
		PeakWorkingSetSize,
		PrivatePageCount,
		ProcessId,
		QuotaNonPagedPoolUsage,
		QuotaPagedPoolUsage,
		QuotaPeakNonPagedPoolUsage,
		QuotaPeakPagedPoolUsage,
		ReadOperationCount,
		ReadTransferCount,
		SessionId,
		ThreadCount,
		VirtualSize,
		WindowsVersion,
		WriteOperationCount,
		WriteTransferCount
	}

	public static class Win32_ProcessExtension {
		public static string GetWMIValue(this Win32_Process enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Process", enumOption.ToString());
	}
}