namespace CWMII.lib.Enums {
	public enum Win32_ExtensionInfoAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Argument,
		Command,
		Extension,
		MIME,
		ProgID,
		ShellNew,
		ShellNewValue,
		Verb
	}

	public static class Win32_ExtensionInfoActionExtension {
		public static string GetWMIValue(this Win32_ExtensionInfoAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ExtensionInfoAction", enumOption.ToString());
	}
}