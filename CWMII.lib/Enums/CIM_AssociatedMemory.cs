namespace CWMII.lib.Enums {
	public enum CIM_AssociatedMemory {
		Antecedent,
		Dependent,
		BusSpeed
	}

	public static class CIM_AssociatedMemoryExtension {
		public static string GetWMIValue(this CIM_AssociatedMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_AssociatedMemory", enumOption.ToString());
	}
}