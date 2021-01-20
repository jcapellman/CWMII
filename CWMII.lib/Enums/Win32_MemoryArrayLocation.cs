namespace CWMII.lib.Enums {
	public enum Win32_MemoryArrayLocation {
		Antecedent,
		Dependent
	}

	public static class Win32_MemoryArrayLocationExtension {
		public static string GetWMIValue(this Win32_MemoryArrayLocation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MemoryArrayLocation", enumOption.ToString());
	}
}