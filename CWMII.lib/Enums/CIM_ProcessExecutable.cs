namespace CWMII.lib.Enums {
	public enum CIM_ProcessExecutable {
		Antecedent,
		Dependent,
		BaseAddress,
		GlobalProcessCount,
		ModuleInstance,
		ProcessCount
	}

	public static class CIM_ProcessExecutableExtension {
		public static string GetWMIValue(this CIM_ProcessExecutable enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ProcessExecutable", enumOption.ToString());
	}
}