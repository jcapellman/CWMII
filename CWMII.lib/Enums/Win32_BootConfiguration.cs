namespace CWMII.lib.Enums {
	public enum Win32_BootConfiguration {
		Caption,
		Description,
		SettingID,
		BootDirectory,
		ConfigurationPath,
		LastDrive,
		Name,
		ScratchDirectory,
		TempDirectory
	}

	public static class Win32_BootConfigurationExtension {
		public static string GetWMIValue(this Win32_BootConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_BootConfiguration", enumOption.ToString());
	}
}