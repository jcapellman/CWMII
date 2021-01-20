namespace CWMII.lib.Enums {
	public enum Win32_SoftwareElementResource {
		Element,
		Setting
	}

	public static class Win32_SoftwareElementResourceExtension {
		public static string GetWMIValue(this Win32_SoftwareElementResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareElementResource", enumOption.ToString());
	}
}