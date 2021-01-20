namespace CWMII.lib.Enums {
	public enum Win32_Registry {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CurrentSize,
		MaximumSize,
		ProposedSize
	}

	public static class Win32_RegistryExtension {
		public static string GetWMIValue(this Win32_Registry enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Registry", enumOption.ToString());
	}
}