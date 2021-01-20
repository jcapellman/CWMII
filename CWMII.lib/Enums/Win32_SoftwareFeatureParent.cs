namespace CWMII.lib.Enums {
	public enum Win32_SoftwareFeatureParent {
		Antecedent,
		Dependent
	}

	public static class Win32_SoftwareFeatureParentExtension {
		public static string GetWMIValue(this Win32_SoftwareFeatureParent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareFeatureParent", enumOption.ToString());
	}
}