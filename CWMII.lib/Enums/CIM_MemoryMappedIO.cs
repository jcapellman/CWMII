namespace CWMII.lib.Enums {
	public enum CIM_MemoryMappedIO {
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

	public static class CIM_MemoryMappedIOExtension {
		public static string GetWMIValue(this CIM_MemoryMappedIO enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_MemoryMappedIO", enumOption.ToString());
	}
}