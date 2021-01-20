namespace CWMII.lib.Enums {
	public enum Win32_Thread {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		CSCreationClassName,
		CSName,
		ExecutionState,
		Handle,
		KernelModeTime,
		OSCreationClassName,
		OSName,
		Priority,
		ProcessCreationClassName,
		ProcessHandle,
		UserModeTime,
		ElapsedTime,
		PriorityBase,
		StartAddress,
		ThreadState,
		ThreadWaitReason
	}

	public static class Win32_ThreadExtension {
		public static string GetWMIValue(this Win32_Thread enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Thread", enumOption.ToString());
	}
}