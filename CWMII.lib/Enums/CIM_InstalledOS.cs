namespace CWMII.lib.Enums {
	public enum CIM_InstalledOS {
		GroupComponent,
		PartComponent,
		PrimaryOS
	}

	public static class CIM_InstalledOSExtension {
		public static string GetWMIValue(this CIM_InstalledOS enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_InstalledOS", enumOption.ToString());
	}
}