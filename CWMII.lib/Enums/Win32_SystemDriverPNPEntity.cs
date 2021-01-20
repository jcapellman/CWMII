namespace CWMII.lib.Enums {
	public enum Win32_SystemDriverPNPEntity {
		Antecedent,
		Dependent
	}

	public static class Win32_SystemDriverPNPEntityExtension {
		public static string GetWMIValue(this Win32_SystemDriverPNPEntity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemDriverPNPEntity", enumOption.ToString());
	}
}