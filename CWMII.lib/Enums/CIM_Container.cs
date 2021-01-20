namespace CWMII.lib.Enums {
	public enum CIM_Container {
		GroupComponent,
		PartComponent,
		LocationWithinContainer
	}

	public static class CIM_ContainerExtension {
		public static string GetWMIValue(this CIM_Container enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Container", enumOption.ToString());
	}
}