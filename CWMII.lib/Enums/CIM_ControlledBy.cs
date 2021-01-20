namespace CWMII.lib.Enums {
	public enum CIM_ControlledBy {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class CIM_ControlledByExtension {
		public static string GetWMIValue(this CIM_ControlledBy enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ControlledBy", enumOption.ToString());
	}
}