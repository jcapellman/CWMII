namespace CWMII.lib.Enums {
	public enum Win32_MemoryDeviceLocation {
		Antecedent,
		Dependent
	}

	public static class Win32_MemoryDeviceLocationExtension {
		public static string GetWMIValue(this Win32_MemoryDeviceLocation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MemoryDeviceLocation", enumOption.ToString());
	}
}