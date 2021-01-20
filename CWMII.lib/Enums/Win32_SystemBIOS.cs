namespace CWMII.lib.Enums {
	public enum Win32_SystemBIOS {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemBIOSExtension {
		public static string GetWMIValue(this Win32_SystemBIOS enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemBIOS", enumOption.ToString());
	}
}