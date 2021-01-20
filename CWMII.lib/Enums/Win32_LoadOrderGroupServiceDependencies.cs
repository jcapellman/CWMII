namespace CWMII.lib.Enums {
	public enum Win32_LoadOrderGroupServiceDependencies {
		Antecedent,
		Dependent
	}

	public static class Win32_LoadOrderGroupServiceDependenciesExtension {
		public static string GetWMIValue(this Win32_LoadOrderGroupServiceDependencies enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LoadOrderGroupServiceDependencies", enumOption.ToString());
	}
}