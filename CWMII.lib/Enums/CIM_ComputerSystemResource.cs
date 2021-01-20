namespace CWMII.lib.Enums {
	public enum CIM_ComputerSystemResource {
		GroupComponent,
		PartComponent
	}

	public static class CIM_ComputerSystemResourceExtension {
		public static string GetWMIValue(this CIM_ComputerSystemResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ComputerSystemResource", enumOption.ToString());
	}
}