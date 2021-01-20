namespace CWMII.lib.Enums {
	public enum Win32_DeviceMemoryAddress {
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
		MemoryType
	}

	public static class Win32_DeviceMemoryAddressExtension {
		public static string GetWMIValue(this Win32_DeviceMemoryAddress enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DeviceMemoryAddress", enumOption.ToString());
	}
}