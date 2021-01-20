namespace CWMII.lib.Enums {
	public enum Win32_SystemAccount {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Domain,
		LocalAccount,
		SID,
		SIDType
	}

	public static class Win32_SystemAccountExtension {
		public static string GetWMIValue(this Win32_SystemAccount enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemAccount", enumOption.ToString());
	}
}