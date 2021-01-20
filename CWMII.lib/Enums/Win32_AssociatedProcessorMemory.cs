namespace CWMII.lib.Enums {
	public enum Win32_AssociatedProcessorMemory {
		Antecedent,
		Dependent,
		BusSpeed
	}

	public static class Win32_AssociatedProcessorMemoryExtension {
		public static string GetWMIValue(this Win32_AssociatedProcessorMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_AssociatedProcessorMemory", enumOption.ToString());
	}
}