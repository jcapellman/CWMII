namespace CWMII.lib.Enums {
	public enum CIM_USBControllerHasHub {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class CIM_USBControllerHasHubExtension {
		public static string GetWMIValue(this CIM_USBControllerHasHub enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_USBControllerHasHub", enumOption.ToString());
	}
}