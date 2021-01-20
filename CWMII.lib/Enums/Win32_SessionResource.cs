namespace CWMII.lib.Enums {
	public enum Win32_SessionResource {
		Antecedent,
		Dependent
	}

	public static class Win32_SessionResourceExtension {
		public static string GetWMIValue(this Win32_SessionResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SessionResource", enumOption.ToString());
	}
}