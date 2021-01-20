namespace CWMII.lib.Enums {
	public enum Win32_PNPAllocatedResource {
		Antecedent,
		Dependent
	}

	public static class Win32_PNPAllocatedResourceExtension {
		public static string GetWMIValue(this Win32_PNPAllocatedResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PNPAllocatedResource", enumOption.ToString());
	}
}