namespace CWMII.lib.Enums {
	public enum CIM_BasedOn {
		Antecedent,
		Dependent,
		EndingAddress,
		StartingAddress
	}

	public static class CIM_BasedOnExtension {
		public static string GetWMIValue(this CIM_BasedOn enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_BasedOn", enumOption.ToString());
	}
}