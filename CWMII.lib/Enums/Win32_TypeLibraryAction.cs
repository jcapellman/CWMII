namespace CWMII.lib.Enums {
	public enum Win32_TypeLibraryAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		Cost,
		Language,
		LibID
	}

	public static class Win32_TypeLibraryActionExtension {
		public static string GetWMIValue(this Win32_TypeLibraryAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_TypeLibraryAction", enumOption.ToString());
	}
}