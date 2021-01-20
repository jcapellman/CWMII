namespace CWMII.lib.Enums {
	public enum Win32_ControllerHasHub {
		Antecedent,
		Dependent,
		NegotiatedDataWidth,
		NegotiatedSpeed,
		AccessState,
		NumberOfHardResets,
		NumberOfSoftResets
	}

	public static class Win32_ControllerHasHubExtension {
		public static string GetWMIValue(this Win32_ControllerHasHub enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ControllerHasHub", enumOption.ToString());
	}
}