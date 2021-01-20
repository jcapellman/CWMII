namespace CWMII.lib.Enums {
	public enum Win32_InstalledSoftwareElement {
		Software,
		System
	}

	public static class Win32_InstalledSoftwareElementExtension {
		public static string GetWMIValue(this Win32_InstalledSoftwareElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_InstalledSoftwareElement", enumOption.ToString());
	}
}