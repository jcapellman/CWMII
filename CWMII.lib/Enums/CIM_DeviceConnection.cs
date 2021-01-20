namespace CWMII.lib.Enums {
	public enum CIM_DeviceConnection {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class CIM_DeviceConnectionExtension {
		public static string GetWMIValue(this CIM_DeviceConnection enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DeviceConnection", enumOption.ToString());
	}
}