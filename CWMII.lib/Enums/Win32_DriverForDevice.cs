namespace CWMII.lib.Enums {
	public enum Win32_DriverForDevice {
		Antecedent,
		Dependent
	}

	public static class Win32_DriverForDeviceExtension {
		public static string GetWMIValue(this Win32_DriverForDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DriverForDevice", enumOption.ToString());
	}
}