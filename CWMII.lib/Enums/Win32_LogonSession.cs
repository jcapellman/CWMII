namespace CWMII.lib.Enums {
	public enum Win32_LogonSession {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		StartTime,
		AuthenticationPackage,
		LogonId,
		LogonType
	}

	public static class Win32_LogonSessionExtension {
		public static string GetWMIValue(this Win32_LogonSession enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogonSession", enumOption.ToString());
	}
}