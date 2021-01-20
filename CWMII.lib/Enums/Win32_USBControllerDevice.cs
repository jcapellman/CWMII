namespace CWMII.lib.Enums {
	public enum Win32_USBControllerDevice {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class Win32_USBControllerDeviceExtension {
		public static string GetWMIValue(this Win32_USBControllerDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_USBControllerDevice", enumOption.ToString());
	}
}