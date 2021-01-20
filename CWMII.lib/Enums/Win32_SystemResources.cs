namespace CWMII.lib.Enums {
	public enum Win32_SystemResources {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SystemResourcesExtension {
		public static string GetWMIValue(this Win32_SystemResources enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemResources", enumOption.ToString());
	}
}