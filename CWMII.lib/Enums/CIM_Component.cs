namespace CWMII.lib.Enums {
	public enum CIM_Component {
		GroupComponent,
		PartComponent
	}

	public static class CIM_ComponentExtension {
		public static string GetWMIValue(this CIM_Component enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Component", enumOption.ToString());
	}
}