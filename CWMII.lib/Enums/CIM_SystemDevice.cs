namespace CWMII.lib.Enums {
	public enum CIM_SystemDevice {
		GroupComponent,
		PartComponent
	}

	public static class CIM_SystemDeviceExtension {
		public static string GetWMIValue(this CIM_SystemDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SystemDevice", enumOption.ToString());
	}
}