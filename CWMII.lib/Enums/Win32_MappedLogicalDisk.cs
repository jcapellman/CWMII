namespace CWMII.lib.Enums {
	public enum Win32_MappedLogicalDisk {
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
		FileSystem,
		MaximumComponentLength,
		ProviderName,
		QuotasDisabled,
		QuotasIncomplete,
		QuotasRebuilding,
		SessionID,
		SupportsDiskQuotas,
		SupportsFileBasedCompression,
		VolumeName,
		VolumeSerialNumber
	}

	public static class Win32_MappedLogicalDiskExtension {
		public static string GetWMIValue(this Win32_MappedLogicalDisk enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_MappedLogicalDisk", enumOption.ToString());
	}
}