namespace CWMII.lib.Enums {
	public enum Win32_ShadowContext {
		Caption,
		Description,
		SettingID,
		ClientAccessible,
		Differential,
		ExposedLocally,
		ExposedRemotely,
		HardwareAssisted,
		Imported,
		Name,
		NoAutoRelease,
		NotSurfaced,
		NoWriters,
		Persistent,
		Plex,
		Transportable
	}

	public static class Win32_ShadowContextExtension {
		public static string GetWMIValue(this Win32_ShadowContext enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ShadowContext", enumOption.ToString());
	}
}