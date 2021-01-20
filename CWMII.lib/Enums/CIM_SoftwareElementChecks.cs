namespace CWMII.lib.Enums {
	public enum CIM_SoftwareElementChecks {
		Check,
		Element,
		Phase
	}

	public static class CIM_SoftwareElementChecksExtension {
		public static string GetWMIValue(this CIM_SoftwareElementChecks enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_SoftwareElementChecks", enumOption.ToString());
	}
}