namespace CWMII.lib.Enums {
	public enum Win32_PatchPackage {
		Caption,
		Description,
		SettingID,
		PatchID,
		ProductCode
	}

	public static class Win32_PatchPackageExtension {
		public static string GetWMIValue(this Win32_PatchPackage enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PatchPackage", enumOption.ToString());
	}
}