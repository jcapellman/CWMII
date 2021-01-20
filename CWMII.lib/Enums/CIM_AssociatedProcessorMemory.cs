namespace CWMII.lib.Enums {
	public enum CIM_AssociatedProcessorMemory {
		Antecedent,
		Dependent,
		BusSpeed
	}

	public static class CIM_AssociatedProcessorMemoryExtension {
		public static string GetWMIValue(this CIM_AssociatedProcessorMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_AssociatedProcessorMemory", enumOption.ToString());
	}
}