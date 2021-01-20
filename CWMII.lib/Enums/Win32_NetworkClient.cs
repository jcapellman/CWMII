namespace CWMII.lib.Enums {
	public enum Win32_NetworkClient {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Manufacturer
	}

	public static class Win32_NetworkClientExtension {
		public static string GetWMIValue(this Win32_NetworkClient enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkClient", enumOption.ToString());
	}
}