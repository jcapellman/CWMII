namespace CWMII.lib.Enums {
	public enum Win32_LaunchCondition {
		Caption,
		CheckID,
		CheckMode,
		Description,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Condition
	}

	public static class Win32_LaunchConditionExtension {
		public static string GetWMIValue(this Win32_LaunchCondition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LaunchCondition", enumOption.ToString());
	}
}