namespace CWMII.lib.Enums {
	public enum CIM_LogicalFile {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		AccessMask,
		Archive,
		Compressed,
		CompressionMethod,
		CreationClassName,
		CreationDate,
		CSCreationClassName,
		CSName,
		Drive,
		EightDotThreeFileName,
		Encrypted,
		EncryptionMethod,
		Extension,
		FileName,
		FileSize,
		FileType,
		FSCreationClassName,
		FSName,
		Hidden,
		InUseCount,
		LastAccessed,
		LastModified,
		Path,
		Readable,
		System,
		Writeable
	}

	public static class CIM_LogicalFileExtension {
		public static string GetWMIValue(this CIM_LogicalFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_LogicalFile", enumOption.ToString());
	}
}