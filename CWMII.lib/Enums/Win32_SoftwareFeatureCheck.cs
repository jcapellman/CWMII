namespace CWMII.lib.Enums {
	public enum Win32_SoftwareFeatureCheck {
		Check,
		Element
	}

	public static class Win32_SoftwareFeatureCheckExtension {
		public static string GetWMIValue(this Win32_SoftwareFeatureCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareFeatureCheck", enumOption.ToString());
	}
}