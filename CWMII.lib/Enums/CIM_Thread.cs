namespace CWMII.lib.Enums {
	public enum CIM_Thread {
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

	public static class CIM_ThreadExtension {
		public static string GetWMIValue(this CIM_Thread enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Thread", enumOption.ToString());
	}
}