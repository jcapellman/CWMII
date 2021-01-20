namespace CWMII.lib.Enums {
	public enum CIM_InstalledSoftwareElement {
		Software,
		System
	}

	public static class CIM_InstalledSoftwareElementExtension {
		public static string GetWMIValue(this CIM_InstalledSoftwareElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_InstalledSoftwareElement", enumOption.ToString());
	}
}