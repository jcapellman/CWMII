namespace CWMII.lib.Enums {
	public enum CIM_Dependency {
		Antecedent,
		Dependent
	}

	public static class CIM_DependencyExtension {
		public static string GetWMIValue(this CIM_Dependency enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Dependency", enumOption.ToString());
	}
}