namespace CWMII.lib.Enums {
	public enum CIM_ServiceServiceDependency {
		Antecedent,
		Dependent,
		TypeOfDependency
	}

	public static class CIM_ServiceServiceDependencyExtension {
		public static string GetWMIValue(this CIM_ServiceServiceDependency enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ServiceServiceDependency", enumOption.ToString());
	}
}