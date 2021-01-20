namespace CWMII.lib.Enums {
	public enum Win32_SoftwareFeatureSoftwareElements {
		GroupComponent,
		PartComponent
	}

	public static class Win32_SoftwareFeatureSoftwareElementsExtension {
		public static string GetWMIValue(this Win32_SoftwareFeatureSoftwareElements enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareFeatureSoftwareElements", enumOption.ToString());
	}
}