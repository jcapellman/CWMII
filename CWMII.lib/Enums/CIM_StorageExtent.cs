namespace CWMII.lib.Enums {
	public enum CIM_StorageExtent {
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

	public static class CIM_StorageExtentExtension {
		public static string GetWMIValue(this CIM_StorageExtent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_StorageExtent", enumOption.ToString());
	}
}