namespace CWMII.lib.Enums {
	public enum Win32_OfflineFilesCache {
		Active,
		Enabled,
		Location
	}

	public static class Win32_OfflineFilesCacheExtension {
		public static string GetWMIValue(this Win32_OfflineFilesCache enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OfflineFilesCache", enumOption.ToString());
	}
}