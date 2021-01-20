namespace CWMII.lib.Enums {
	public enum Win32_PatchFile {
		Check,
		Setting
	}

	public static class Win32_PatchFileExtension {
		public static string GetWMIValue(this Win32_PatchFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PatchFile", enumOption.ToString());
	}
}