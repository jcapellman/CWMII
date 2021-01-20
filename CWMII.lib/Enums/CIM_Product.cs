namespace CWMII.lib.Enums {
	public enum CIM_Product {
		Caption,
		Description,
		IdentifyingNumber,
		Name,
		SKUNumber,
		Vendor,
		Version,
		UUID
	}

	public static class CIM_ProductExtension {
		public static string GetWMIValue(this CIM_Product enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Product", enumOption.ToString());
	}
}