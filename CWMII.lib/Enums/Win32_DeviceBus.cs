namespace CWMII.lib.Enums {
	public enum Win32_DeviceBus {
		Antecedent,
		Dependent
	}

	public static class Win32_DeviceBusExtension {
		public static string GetWMIValue(this Win32_DeviceBus enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DeviceBus", enumOption.ToString());
	}
}