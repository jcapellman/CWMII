namespace CWMII.lib.Enums {
	public enum Win32_LogicalDisk {
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
		FreeSpace,
		Size,
		Compressed,
		DriveType,
		FileSystem,
		MaximumComponentLength,
		MediaType,
		ProviderName,
		QuotasDisabled,
		QuotasIncomplete,
		QuotasRebuilding,
		SupportsDiskQuotas,
		SupportsFileBasedCompression,
		VolumeDirty,
		VolumeName,
		VolumeSerialNumber
	}

	public static class Win32_LogicalDiskExtension {
		public static string GetWMIValue(this Win32_LogicalDisk enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LogicalDisk", enumOption.ToString());
	}
}