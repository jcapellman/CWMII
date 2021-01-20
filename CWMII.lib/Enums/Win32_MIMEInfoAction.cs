namespace CWMII.lib.Enums {
	public enum Win32_MIMEInfoAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		CLSID,
		ContentType,
		Extension
	}

	public static class Win32_MIMEInfoActionExtension {
		public static string GetWMIValue(this Win32_MIMEInfoAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MIMEInfoAction", enumOption.ToString());
	}
}