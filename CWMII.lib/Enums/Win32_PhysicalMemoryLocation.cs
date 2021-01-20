namespace CWMII.lib.Enums {
	public enum Win32_PhysicalMemoryLocation {
		GroupComponent,
		PartComponent,
		LocationWithinContainer
	}

	public static class Win32_PhysicalMemoryLocationExtension {
		public static string GetWMIValue(this Win32_PhysicalMemoryLocation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PhysicalMemoryLocation", enumOption.ToString());
	}
}