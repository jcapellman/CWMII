namespace CWMII.lib.Enums {
	public enum Win32_SoftwareElementCondition {
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

	public static class Win32_SoftwareElementConditionExtension {
		public static string GetWMIValue(this Win32_SoftwareElementCondition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareElementCondition", enumOption.ToString());
	}
}