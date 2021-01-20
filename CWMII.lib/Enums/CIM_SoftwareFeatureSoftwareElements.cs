namespace CWMII.lib.Enums {
	public enum CIM_SoftwareFeatureSoftwareElements {
		GroupComponent,
		PartComponent
	}

	public static class CIM_SoftwareFeatureSoftwareElementsExtension {
		public static string GetWMIValue(this CIM_SoftwareFeatureSoftwareElements enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SoftwareFeatureSoftwareElements", enumOption.ToString());
	}
}