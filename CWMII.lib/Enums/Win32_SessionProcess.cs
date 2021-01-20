namespace CWMII.lib.Enums {
	public enum Win32_SessionProcess {
		Antecedent,
		Dependent
	}

	public static class Win32_SessionProcessExtension {
		public static string GetWMIValue(this Win32_SessionProcess enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SessionProcess", enumOption.ToString());
	}
}