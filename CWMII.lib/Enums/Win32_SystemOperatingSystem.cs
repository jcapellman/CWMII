namespace CWMII.lib.Enums {
	public enum Win32_SystemOperatingSystem {
		GroupComponent,
		PartComponent,
		PrimaryOS
	}

	public static class Win32_SystemOperatingSystemExtension {
		public static string GetWMIValue(this Win32_SystemOperatingSystem enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemOperatingSystem", enumOption.ToString());
	}
}