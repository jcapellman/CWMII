namespace CWMII.lib.Enums {
	public enum Win32_PageFileUsage {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AllocatedBaseSize,
		CurrentUsage,
		PeakUsage,
		TempPageFile
	}

	public static class Win32_PageFileUsageExtension {
		public static string GetWMIValue(this Win32_PageFileUsage enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PageFileUsage", enumOption.ToString());
	}
}