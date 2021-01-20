namespace CWMII.lib.Enums {
	public enum Win32_LoadOrderGroup {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		DriverEnabled,
		GroupOrder
	}

	public static class Win32_LoadOrderGroupExtension {
		public static string GetWMIValue(this Win32_LoadOrderGroup enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LoadOrderGroup", enumOption.ToString());
	}
}