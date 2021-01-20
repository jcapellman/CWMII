namespace CWMII.lib.Enums {
	public enum Win32_DependentService {
		Antecedent,
		Dependent,
		TypeOfDependency
	}

	public static class Win32_DependentServiceExtension {
		public static string GetWMIValue(this Win32_DependentService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DependentService", enumOption.ToString());
	}
}