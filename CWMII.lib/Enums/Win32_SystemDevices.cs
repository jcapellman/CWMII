namespace CWMII.lib.Enums {
	public enum Win32_SystemDevices {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemDevicesExtension {
		public static string GetWMIValue(this Win32_SystemDevices enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemDevices", enumOption.ToString());
	}
}