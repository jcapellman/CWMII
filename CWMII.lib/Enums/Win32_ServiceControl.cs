namespace CWMII.lib.Enums {
	public enum Win32_ServiceControl {
		Caption,
		Description,
		SettingID,
		Arguments,
		Event,
		ID,
		Name,
		ProductCode,
		Wait
	}

	public static class Win32_ServiceControlExtension {
		public static string GetWMIValue(this Win32_ServiceControl enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ServiceControl", enumOption.ToString());
	}
}