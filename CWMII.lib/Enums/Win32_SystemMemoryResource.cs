namespace CWMII.lib.Enums {
	public enum Win32_SystemMemoryResource {
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

	public static class Win32_SystemMemoryResourceExtension {
		public static string GetWMIValue(this Win32_SystemMemoryResource enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemMemoryResource", enumOption.ToString());
	}
}