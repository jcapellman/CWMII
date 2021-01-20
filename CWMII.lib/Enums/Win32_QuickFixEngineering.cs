namespace CWMII.lib.Enums {
	public enum Win32_QuickFixEngineering {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CSName,
		FixComments,
		HotFixID,
		InstalledBy,
		InstalledOn,
		ServicePackInEffect
	}

	public static class Win32_QuickFixEngineeringExtension {
		public static string GetWMIValue(this Win32_QuickFixEngineering enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_QuickFixEngineering", enumOption.ToString());
	}
}