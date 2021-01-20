namespace CWMII.lib.Enums {
	public enum Win32_SystemServices {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemServicesExtension {
		public static string GetWMIValue(this Win32_SystemServices enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemServices", enumOption.ToString());
	}
}