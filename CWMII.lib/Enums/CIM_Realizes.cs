namespace CWMII.lib.Enums {
	public enum CIM_Realizes {
		Antecedent,
		Dependent
	}

	public static class CIM_RealizesExtension {
		public static string GetWMIValue(this CIM_Realizes enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Realizes", enumOption.ToString());
	}
}