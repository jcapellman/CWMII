namespace CWMII.lib.Enums {
	public enum Win32_OptionalFeature {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		InstallState
	}

	public static class Win32_OptionalFeatureExtension {
		public static string GetWMIValue(this Win32_OptionalFeature enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OptionalFeature", enumOption.ToString());
	}
}