namespace CWMII.lib.Enums {
	public enum CIM_PackagedComponent {
		GroupComponent,
		PartComponent,
		LocationWithinContainer
	}

	public static class CIM_PackagedComponentExtension {
		public static string GetWMIValue(this CIM_PackagedComponent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PackagedComponent", enumOption.ToString());
	}
}