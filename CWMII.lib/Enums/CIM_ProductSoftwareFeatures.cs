namespace CWMII.lib.Enums {
	public enum CIM_ProductSoftwareFeatures {
		Component,
		Product
	}

	public static class CIM_ProductSoftwareFeaturesExtension {
		public static string GetWMIValue(this CIM_ProductSoftwareFeatures enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ProductSoftwareFeatures", enumOption.ToString());
	}
}