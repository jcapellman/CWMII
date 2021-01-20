namespace CWMII.lib.Enums {
	public enum Win32_DiskPartition {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Availability,
		ConfigManagerErrorCode,
		ConfigManagerUserConfig,
		CreationClassName,
		DeviceID,
		ErrorCleared,
		ErrorDescription,
		LastErrorCode,
		PNPDeviceID,
		PowerManagementCapabilities,
		PowerManagementSupported,
		StatusInfo,
		SystemCreationClassName,
		SystemName,
		Access,
		BlockSize,
		ErrorMethodology,
		NumberOfBlocks,
		Purpose,
		Bootable,
		PrimaryPartition,
		BootPartition,
		DiskIndex,
		HiddenSectors,
		Index,
		RewritePartition,
		Size,
		StartingOffset,
		Type
	}

	public static class Win32_DiskPartitionExtension {
		public static string GetWMIValue(this Win32_DiskPartition enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_DiskPartition", enumOption.ToString());
	}
}