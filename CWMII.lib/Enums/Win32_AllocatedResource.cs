namespace CWMII.lib.Enums {
	public enum Win32_AllocatedResource {
		Antecedent,
		Dependent
	}

	public static class Win32_AllocatedResourceExtension {
		public static string GetWMIValue(this Win32_AllocatedResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_AllocatedResource", enumOption.ToString());
	}
}