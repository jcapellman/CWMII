namespace CWMII.lib.Enums {
	public enum Win32_Condition {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Condition,
		Feature,
		Level
	}

	public static class Win32_ConditionExtension {
		public static string GetWMIValue(this Win32_Condition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Condition", enumOption.ToString());
	}
}