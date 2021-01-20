namespace CWMII.lib.Enums {
	public enum Win32_RegistryAction {
		ActionID,
		Caption,
		Description,
		Direction,
		Name,
		SoftwareElementID,
		SoftwareElementState,
		TargetOperatingSystem,
		Version,
		EntryName,
		EntryValue,
		key,
		Registry,
		Root
	}

	public static class Win32_RegistryActionExtension {
		public static string GetWMIValue(this Win32_RegistryAction enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_RegistryAction", enumOption.ToString());
	}
}