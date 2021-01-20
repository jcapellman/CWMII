namespace CWMII.lib.Enums {
	public enum Win32_SCSIControllerDevice {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class Win32_SCSIControllerDeviceExtension {
		public static string GetWMIValue(this Win32_SCSIControllerDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SCSIControllerDevice", enumOption.ToString());
	}
}