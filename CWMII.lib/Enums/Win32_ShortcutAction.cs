namespace CWMII.lib.Enums {
	public enum Win32_ShortcutAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Arguments,
		HotKey,
		IconIndex,
		Shortcut,
		ShowCmd,
		Target,
		WkDir
	}

	public static class Win32_ShortcutActionExtension {
		public static string GetWMIValue(this Win32_ShortcutAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_ShortcutAction", enumOption.ToString());
	}
}