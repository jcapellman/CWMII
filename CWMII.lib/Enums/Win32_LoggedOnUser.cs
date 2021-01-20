namespace CWMII.lib.Enums {
	public enum Win32_LoggedOnUser {
		Antecedent,
		Dependent
	}

	public static class Win32_LoggedOnUserExtension {
		public static string GetWMIValue(this Win32_LoggedOnUser enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LoggedOnUser", enumOption.ToString());
	}
}