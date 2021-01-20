namespace CWMII.lib.Enums {
	public enum Win32_Patch {
		Caption,
		Description,
		SettingID,
		Attributes,
		File,
		PatchSize,
		ProductCode,
		Sequence
	}

	public static class Win32_PatchExtension {
		public static string GetWMIValue(this Win32_Patch enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Patch", enumOption.ToString());
	}
}