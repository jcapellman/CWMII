namespace CWMII.lib.Enums {
	public enum Win32_SoftwareFeatureAction {
		Action,
		Element
	}

	public static class Win32_SoftwareFeatureActionExtension {
		public static string GetWMIValue(this Win32_SoftwareFeatureAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareFeatureAction", enumOption.ToString());
	}
}