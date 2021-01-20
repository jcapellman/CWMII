namespace CWMII.lib.Enums {
	public enum Win32_ProductSoftwareFeatures {
		Component,
		Product
	}

	public static class Win32_ProductSoftwareFeaturesExtension {
		public static string GetWMIValue(this Win32_ProductSoftwareFeatures enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ProductSoftwareFeatures", enumOption.ToString());
	}
}