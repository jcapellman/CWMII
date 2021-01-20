namespace CWMII.lib.Enums {
	public enum Win32_Group {
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

	public static class Win32_GroupExtension {
		public static string GetWMIValue(this Win32_Group enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Group", enumOption.ToString());
	}
}