namespace CWMII.lib.Enums {
	public enum CIM_SystemComponent {
		GroupComponent,
		PartComponent
	}

	public static class CIM_SystemComponentExtension {
		public static string GetWMIValue(this CIM_SystemComponent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SystemComponent", enumOption.ToString());
	}
}