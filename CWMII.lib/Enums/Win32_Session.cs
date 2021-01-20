namespace CWMII.lib.Enums {
	public enum Win32_Session {
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

	public static class Win32_SessionExtension {
		public static string GetWMIValue(this Win32_Session enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Session", enumOption.ToString());
	}
}