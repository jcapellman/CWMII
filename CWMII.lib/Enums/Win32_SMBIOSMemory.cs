namespace CWMII.lib.Enums {
	public enum Win32_SMBIOSMemory {
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
		AdditionalErrorData,
		CorrectableError,
		EndingAddress,
		ErrorAccess,
		ErrorAddress,
		ErrorData,
		ErrorDataOrder,
		ErrorInfo,
		ErrorResolution,
		ErrorTime,
		ErrorTransferSize,
		OtherErrorDescription,
		StartingAddress,
		SystemLevelAddress,
		ErrorGranularity
	}

	public static class Win32_SMBIOSMemoryExtension {
		public static string GetWMIValue(this Win32_SMBIOSMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SMBIOSMemory", enumOption.ToString());
	}
}