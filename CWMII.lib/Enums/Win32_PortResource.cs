namespace CWMII.lib.Enums {
	public enum Win32_PortResource {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		CSCreationClassName,
		CSName,
		EndingAddress,
		StartingAddress,
		Alias
	}

	public static class Win32_PortResourceExtension {
		public static string GetWMIValue(this Win32_PortResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PortResource", enumOption.ToString());
	}
}