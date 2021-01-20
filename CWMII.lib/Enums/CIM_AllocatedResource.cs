namespace CWMII.lib.Enums {
	public enum CIM_AllocatedResource {
		Antecedent,
		Dependent
	}

	public static class CIM_AllocatedResourceExtension {
		public static string GetWMIValue(this CIM_AllocatedResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_AllocatedResource", enumOption.ToString());
	}
}