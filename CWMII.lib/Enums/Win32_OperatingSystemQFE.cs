namespace CWMII.lib.Enums {
	public enum Win32_OperatingSystemQFE {
		Antecedent,
		Dependent
	}

	public static class Win32_OperatingSystemQFEExtension {
		public static string GetWMIValue(this Win32_OperatingSystemQFE enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OperatingSystemQFE", enumOption.ToString());
	}
}