namespace CWMII.lib.Enums {
	public enum Win32_PnPDevice {
		SameElement,
		SystemElement
	}

	public static class Win32_PnPDeviceExtension {
		public static string GetWMIValue(this Win32_PnPDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PnPDevice", enumOption.ToString());
	}
}