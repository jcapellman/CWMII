namespace CWMII.lib.Enums {
	public enum Win32_SystemTimeZone {
		Element,
		Setting
	}

	public static class Win32_SystemTimeZoneExtension {
		public static string GetWMIValue(this Win32_SystemTimeZone enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemTimeZone", enumOption.ToString());
	}
}