namespace CWMII.lib.Enums {
	public enum Win32_MemoryDeviceArray {
		GroupComponent,
		PartComponent
	}

	public static class Win32_MemoryDeviceArrayExtension {
		public static string GetWMIValue(this Win32_MemoryDeviceArray enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MemoryDeviceArray", enumOption.ToString());
	}
}