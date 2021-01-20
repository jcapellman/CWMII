namespace CWMII.lib.Enums {
	public enum Win32_ApplicationCommandLine {
		Antecedent,
		Dependent
	}

	public static class Win32_ApplicationCommandLineExtension {
		public static string GetWMIValue(this Win32_ApplicationCommandLine enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ApplicationCommandLine", enumOption.ToString());
	}
}